using HomeworkTwentyEightLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeworkTwentyEight
{
    public partial class PersonEntry : Form
    {
        BindingList<AddressModel> addresses = new BindingList<AddressModel>();

        public PersonEntry()
        {
            InitializeComponent();

            addresses.Add(new AddressModel { StreetAddress = "123 Saan Man Street", City = "Wantong City" });

            addressesList.DataSource = addresses;
            addressesList.DisplayMember = nameof(AddressModel.AddressDisplayValue);
        }
    }
}
