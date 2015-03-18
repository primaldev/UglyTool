using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.AccountManagement;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UglyTool
{
    public partial class MainForm : Form
    {

       private string searchdomain;

        public MainForm()
        {
            InitializeComponent();
            getDomains();


            
        }


        private void getDomains()
        {
           

            using (var forest = Forest.GetCurrentForest())
            {
                foreach (Domain domain in forest.Domains)
                {
                    selectDomain.Items.Add(domain.Name);

                   // domain.Dispose();
                }
            }
            selectDomain.SelectedItem = System.Net.NetworkInformation.IPGlobalProperties.GetIPGlobalProperties().DomainName;
        }

        private void searchUsersGroups()
        {
            searchdomain =  selectDomain.Text;
            

            if (searchText.Text.Length > 1)
            {
                progressImage.Visible = true;
                itemMemberOf.Text = "";
                itemMembers.Text = "";
                itemProperties.Text = "";
                SearchResultGroups.Items.Clear();
                searchResultUsers.Items.Clear();
                searchUserNameWorker.RunWorkerAsync();
                searchUsersWorker.RunWorkerAsync();

                searchGroupsWorker.RunWorkerAsync(); //last job must hide progress image
              
            }
           
        }


       

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                searchUsersGroups();
               
            }

            
        }

        private void searchResultUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            itemMemberOf.Text = "";
            itemProperties.Text = "";
            itemMembers.Text = "";
            if (searchResultUsers.SelectedItem != null)
            {

                UserPrincipal userPricelpal = (UserPrincipal)searchResultUsers.SelectedItem;
                //

                itemProperties.Text += "Account: " + userPricelpal.SamAccountName + "\r\n";
                itemProperties.Text += "Name: " + userPricelpal.Name + "\r\n";
                itemProperties.Text += "AccountExpirationDate: " + userPricelpal.AccountExpirationDate + "\r\n";
                itemProperties.Text += "AccountLockoutTime: " + userPricelpal.AccountLockoutTime + "\r\n";
                itemProperties.Text += "BadLogonCount: " + userPricelpal.BadLogonCount + "\r\n";
                itemProperties.Text += "DisplayName: " + userPricelpal.DisplayName + "\r\n";
                itemProperties.Text += "Description: " + userPricelpal.Description + "\r\n";

                itemProperties.Text += "EmailAddress: " + userPricelpal.EmailAddress + "\r\n";
                itemProperties.Text += "GivenName: " + userPricelpal.GivenName + "\r\n";
                itemProperties.Text += "HomeDirectory: " + userPricelpal.HomeDirectory + "\r\n";
                itemProperties.Text += "HomeDrive: " + userPricelpal.HomeDrive + "\r\n";
                itemProperties.Text += "LastLogon: " + userPricelpal.LastLogon + "\r\n";
                itemProperties.Text += "LastPasswordSet: " + userPricelpal.LastPasswordSet + "\r\n";
                itemProperties.Text += "PasswordNeverExpires: " + userPricelpal.PasswordNeverExpires + "\r\n";
                itemProperties.Text += "Surname: " + userPricelpal.Surname + "\r\n";
                itemProperties.Text += "Enabled: " + userPricelpal.Enabled + "\r\n";
                itemProperties.Text += "MiddleName: " + userPricelpal.MiddleName + "\r\n";
                itemProperties.Text += "\r\n";
                itemProperties.Text += "DistinguishedName: " + userPricelpal.DistinguishedName + "\r\n";

                try
                {
                    /*
                    using (var userGroups = userPricelpal.GetGroups())
                    {
                        userGroups.OrderBy(x => x.SamAccountName);
                    foreach(Principal group in userGroups) {
                        itemMemberOf.Text += group.Name + "\r\n";
                    }
                    }
                    */
                    var userGroups = userPricelpal.GetGroups().OrderBy(x => x.SamAccountName);


                    foreach (Principal group in userGroups)
                    {
                        itemMemberOf.Text += group.Name + "\r\n";
                    }



                }
                catch
                {
                    //do nothing
                }

            }
            
        }


        private void SearchResultGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchResultGroups.Enabled = false;
            itemMemberOf.Text = "";
            itemProperties.Text = "";
            itemMembers.Text = "";
           
           GroupPrincipal groupPrincipal =  (GroupPrincipal)SearchResultGroups.SelectedItem;
           progressImage.Visible = true;
           var item = SearchResultGroups.SelectedItem;
           groupSelectWorker.RunWorkerAsync(item); 

           itemProperties.Text += "Account: " + groupPrincipal.SamAccountName + "\r\n";
           itemProperties.Text += "Name: " + groupPrincipal.Name + "\r\n";
           itemProperties.Text += "DisplayName: " + groupPrincipal.DisplayName + "\r\n";
           
           itemProperties.Text += "GroupScope: " + groupPrincipal.GroupScope + "\r\n";
           itemProperties.Text += "IsSecurityGroup: " + groupPrincipal.IsSecurityGroup + "\r\n";
           itemProperties.Text += "Description: " + groupPrincipal.Description + "\r\n";
           itemProperties.Text += "\r\n";
           itemProperties.Text += "DistinguishedName: " + groupPrincipal.DistinguishedName + "\r\n";

           try
           {
       
               using (var groupGroups = groupPrincipal.GetGroups())
               {
                   groupGroups.OrderBy(x => x.SamAccountName);
                   foreach (Principal group in groupGroups)
                   {
                       itemMemberOf.Text += group.Name + "\r\n";
                   }
               }
              
           }
           catch (Exception)
           {
               
              
           }

      
        }


        private void button1_Click(object sender, EventArgs e)
        {
            searchUsersGroups();
        }

    
        private void searchUsersWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            string searWildText = "*" + searchText.Text + "*";

            PrincipalContext insPrincipalContext = new PrincipalContext(ContextType.Domain, searchdomain);          
            
            UserPrincipal insUserPrincipal;
            insUserPrincipal = new UserPrincipal(insPrincipalContext);

            insUserPrincipal.SamAccountName = searWildText;
            PrincipalSearcher insPrincipalSearcher = new PrincipalSearcher();
            insPrincipalSearcher.QueryFilter = insUserPrincipal;

            Principal[] searchResults = insPrincipalSearcher.FindAll().OrderBy(x => x.SamAccountName).ToArray();

                e.Result = searchResults;
            

        }

        private void searchGroupsWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            PrincipalContext insaPrincipalContext = new PrincipalContext(ContextType.Domain, searchdomain);
            string searWildText = "*" + searchText.Text + "*";
           
            GroupPrincipal insGroupPrincipal = new GroupPrincipal(insaPrincipalContext);
            insGroupPrincipal.Name = searWildText;

            PrincipalSearcher insPrincipalSearcher = new PrincipalSearcher();
            insPrincipalSearcher.QueryFilter = insGroupPrincipal;
            

                Principal[] searchResults = insPrincipalSearcher.FindAll().OrderBy(x=>x.SamAccountName).ToArray();

                e.Result = searchResults;
            

        }

        private void searchGroupsWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            Principal[] searchResults = (Principal[])e.Result;

            foreach (GroupPrincipal result in searchResults)
            {
                SearchResultGroups.Items.Add(result);
            }
            progressImage.Visible = false;
        }

        private void searchUsersWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Principal[] searchResults = (Principal[])e.Result;
                foreach (UserPrincipal result in searchResults)
                {
                    searchResultUsers.Items.Add(result);
                }
            
        }

        private void searchUserNameWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            string searWildText = "*" + searchText.Text + "*";
            PrincipalContext insPrincipalContext = new PrincipalContext(ContextType.Domain, searchdomain);
            
            UserPrincipal insUserPrincipal;
            insUserPrincipal = new UserPrincipal(insPrincipalContext);

            insUserPrincipal.Name = searWildText;
            PrincipalSearcher insPrincipalSearcher = new PrincipalSearcher();
            using (insPrincipalSearcher.QueryFilter = insUserPrincipal)
            {
                Principal[] searchResults = insPrincipalSearcher.FindAll().OrderBy(x=>x.SamAccountName).ToArray();
                e.Result = searchResults;
            }
        }

        private void searchUserNameWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Principal[] searchResults = (Principal[])e.Result;
            foreach (UserPrincipal result in searchResults)
            {
                searchResultUsers.Items.Add(result);
            }
        }

        private void groupSelectWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            GroupPrincipal groupPrincipal = (GroupPrincipal)e.Argument;
            
                Principal[] memberGroups = groupPrincipal.GetMembers().OrderBy(x=>x.SamAccountName).ToArray();
                e.Result = memberGroups;
            
        }

        private void groupSelectWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Principal[] memberGroups = (Principal[])e.Result;
            string members = "";
            foreach (Principal group in memberGroups)
            {
                members += group.SamAccountName + "\r\n";
            }

            itemMembers.Text = members;
            progressImage.Visible = false;
            SearchResultGroups.Enabled = true;
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AboutBox about = new AboutBox();
            about.Show();
        }

        

    }
}
