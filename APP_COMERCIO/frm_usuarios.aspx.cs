using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace APP_COMERCIO
{
    public partial class frm_usuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_registrar_Click(object sender, EventArgs e)
        {
            CLS_USUARIO objUsuarios = new CLS_USUARIO();
            objUsuarios.fnt_agregar(txt_codigo.Text, txt_nombre.Text, txt_contacto.Text, txt_correo.Text, txt_direccion.Text);
            lbl_mensaje.Text = objUsuarios.getMensaje();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void btn_cancelar_Click(object sender, EventArgs e)
        {
            txt_codigo.Text = "";
            txt_nombre.Text = "";
            txt_contacto.Text = "";
            txt_correo.Text = "";
            txt_direccion.Text = "";
            txt_codigo.Focus();
        }

        protected void btn_consultar_Click(object sender, EventArgs e)
        {
            CLS_USUARIO objConsultar = new CLS_USUARIO();
            objConsultar.fnt_consultar(txt_codigo.Text);
            txt_contacto.Text = objConsultar.getContacto();
            txt_correo.Text = objConsultar.getCorreo();
            txt_direccion.Text = objConsultar.getDireccion();
            txt_nombre.Text = objConsultar.getNombre(); 
        }
    }
}