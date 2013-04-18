using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using System.Linq;


namespace GridViewTest
{
    public partial class Default : System.Web.UI.Page
    {
        SqlConnection sqlcon;
        SqlCommand sqlcom;
        string strCon = "Data Source=(local);Database=wxd;Uid=sa;Pwd=1q2w3e4r";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bind();
            }
        }
        //绑定GridView
        public void bind()
        {
            string sqlstr = "select * from Admin";
            sqlcon = new SqlConnection(strCon);
            SqlDataAdapter myda = new SqlDataAdapter(sqlstr, sqlcon);
            DataSet myds = new DataSet();
            sqlcon.Open();
            myda.Fill(myds, "Admin");
            GridView1.DataSource = myds;
            GridView1.DataKeyNames = new string[] { "CID" };
            GridView1.DataBind();
            sqlcon.Close();
        }
        //编辑
        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            bind();
        }
        //更新
        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            sqlcon = new SqlConnection(strCon);
            string sqlstr = "update Admin set  Name='"
                + ((TextBox)(GridView1.Rows[e.RowIndex].Cells[1].Controls[0])).Text.ToString().Trim() + "',Sex='"
                + ((TextBox)(GridView1.Rows[e.RowIndex].Cells[2].Controls[0])).Text.ToString().Trim() + "',Address='"
                + ((TextBox)(GridView1.Rows[e.RowIndex].Cells[3].Controls[0])).Text.ToString().Trim() + "' where CID='"
                + GridView1.DataKeys[e.RowIndex].Value.ToString() + "'";
            sqlcom = new SqlCommand(sqlstr, sqlcon);
            sqlcon.Open();
            sqlcom.ExecuteNonQuery();
            sqlcon.Close();
            GridView1.EditIndex = -1;
            bind();
        }
        //取消
        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            bind();
        }
        //删除
        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string sqlstr = "delete from Admin where CID='" + GridView1.DataKeys[e.RowIndex].Value.ToString() + "'";
            sqlcon = new SqlConnection(strCon);
            sqlcom = new SqlCommand(sqlstr, sqlcon);
            sqlcon.Open();
            sqlcom.ExecuteNonQuery();
            sqlcon.Close();
            bind();

        }
        //固定列宽
        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowState == (DataControlRowState.Edit | DataControlRowState.Alternate) || e.Row.RowState == DataControlRowState.Edit)
            {
                for (int i = 1; i < GridView1.Columns.Count - 4; i++)
                {

                    TextBox txt = (TextBox)e.Row.Cells[i].Controls[0];
                    txt.Width = Unit.Pixel(50);
                }
            }

            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                //当鼠标放上去的时候 先保存当前行的背景颜色 并给附一颜色 
                e.Row.Attributes.Add("onmouseover", "currentcolor=this.style.backgroundColor;this.style.backgroundColor='#C9D3E2',this.style.fontWeight='';");
                //当鼠标离开的时候 将背景颜色还原的以前的颜色 
                e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=currentcolor,this.style.fontWeight='';");
                e.Row.Attributes["style"] = "Cursor:pointer";
            }
        }
    }
}