using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class tests_Flush : Steeg.Framework.Web.UI.ServicedPage<Steeg.Framework.Security.IUserService>
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.Get<Castle.Facilities.NHibernateIntegration.ISessionManager>().OpenSession().Flush();
    }
}