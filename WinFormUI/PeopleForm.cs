using DemoLibrary;
using Squirrel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormUI
{
  public partial class PeopleForm : Form
  {
    private List<PersonModel> people = new List<PersonModel>();

    public PeopleForm()
    {
      InitializeComponent();

      LoadPeopleList();

      AddVersionNumber();

      CheckForUpdates();
    }

    private void AddVersionNumber()
    {
      System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
      FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);

      this.Text += $" v.{versionInfo.FileVersion}";
    }

    private async Task CheckForUpdates()
    {
      using (var manager = new UpdateManager(@"C:\data\Releases"))
      {
        await manager.UpdateApp();
      }
    }

    private void addPersonButton_Click(object sender, EventArgs e)
    {
      PersonModel p = new PersonModel();

      p.FirstName = firstNameTextBox.Text;
      p.LastName = lastNameTextBox.Text;

      // TODO - do something with this item
      SqliteDataAccess.SavePerson(p);
      WireUpPeopleList();

      firstNameTextBox.Text = "";
      lastNameTextBox.Text = "";
    }

    private void WireUpPeopleList()
    {
      listPeopleListBox.DataSource = null;
      listPeopleListBox.DataSource = people;
      listPeopleListBox.DisplayMember = "FullName";
    }

    private void refreshListButton_Click(object sender, EventArgs e)
    {
      LoadPeopleList();
    }

    private void LoadPeopleList()
    {
      //people.Add(new PersonModel { FirstName = "Tim", LastName = "Corey" });
      //people.Add(new PersonModel { FirstName = "John", LastName = "Doe" });
      //people.Add(new PersonModel { FirstName = "Mary", LastName = "Smith" });

      people = SqliteDataAccess.LoadPeople();

      WireUpPeopleList();

    }
  }
}
