using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.ServiceReference1;
using Ionic.Zip;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindDataList();
        }

        protected void BindDataList()
        {
            DirectoryInfo dir = new DirectoryInfo(MapPath("Zip"));
            FileInfo[] files = dir.GetFiles();
            ArrayList listItems = new ArrayList();
            foreach(FileInfo info in files)
            {
                listItems.Add(info);
            }
            gvZip.DataSource = listItems;
            gvZip.DataBind();
        }
        /// <summary>
        /// creating Button Link
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button1_Click(object sender, EventArgs e)
        {
            using (var zip = new ZipFile())
            {
                if(FileUpload1.HasFile)
                {
                    //zip.Password = "123";
                    //zip.Encryption = EncryptionAlgorithm.WinZipAes256;
                    string filename = Path.GetFileName(FileUpload1.FileName);
                    FileUpload1.SaveAs(Server.MapPath("~/Upload1//") + filename);
                    string filenamewithouextension = Path.GetFileNameWithoutExtension(FileUpload1.FileName);
                    string destdir = Server.MapPath(".") + @"\Zip\" + filenamewithouextension + ".Zip";  //desination directory
                    zip.AddDirectory(Server.MapPath(".") + @"\Upload\");  //adding directory
                    zip.Save(destdir);
                    string[] files = System.IO.Directory.GetFiles(Server.MapPath("~/Upload//"));
                    foreach(string f in files)
                    {
                        System.IO.File.Delete(f);
                    }
                    BindDataList();
                }
            }
        }
        protected void gvZip_RowCommand(object sender,GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Download")
            {
                Response.Clear();
                Response.ContentType = "application/octet-stream";
                Response.AppendHeader("content-disposition", "attachment;filename=" + e.CommandArgument.ToString());
                Response.TransmitFile(Server.MapPath("~/Zip//" + e.CommandArgument.ToString()));
                Response.Clear();
            }
        }

        protected void gvZip_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}