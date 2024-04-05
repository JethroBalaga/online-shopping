using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;

namespace online_shopping.Module.BusinessObjects
{
    [DefaultClassOptions]
    //[ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class admin : XPObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public admin(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        string admin_Role;
        string admin_Name;
        string admin_Id;

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Admin_Id
        {
            get => admin_Id;
            set => SetPropertyValue(nameof(Admin_Id), ref admin_Id, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Admin_Name
        {
            get => admin_Name;
            set => SetPropertyValue(nameof(Admin_Name), ref admin_Name, value);
        }
        
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string admin_role
        {
            get => admin_Role;
            set => SetPropertyValue(nameof(admin_role), ref admin_Role, value);
        }
    }
}