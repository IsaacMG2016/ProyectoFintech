using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Npgsql;
using System.Configuration;

namespace VentanasFintech
{
    public partial class Form2 : Form
    {

        //TreeNode Categoria_1;
        //TreeNode Categoria_2;
        //TreeNode Categoria_3;
        TreeNode NuevaSecuencia;

        //NpgsqlDataAdapter dadapter;
        //DataSet dset;




        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //desplegarMenu();
        }

        //private void desplegarMenu()
        //{




        //    if (textBox1.Text.Equals(""))
        //    {
        //        MessageBox.Show("Falta Asignar Nombre", "Nueva Secuencia",
        //        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        //    }
        //    else
        //    {

        //        string connstring = ConfigurationManager.ConnectionStrings["My conexion"].ConnectionString;
        //        dadapter = new NpgsqlDataAdapter("select * from tb_categoria; select * from tb_proceso; select * from tb_secuencia", connstring);
        //        dset = new DataSet();
        //        dadapter.Fill(dset);

        //        string idcateg;
        //        foreach (DataRow row in dset.Tables[0].Rows)
        //        {
        //            idcateg = row["id"].ToString();
        //            TreeNode catnode = new TreeNode(row["nombre"].ToString());
        //            foreach (DataRow row2 in dset.Tables[1].Rows)
        //            {
        //                TreeNode procnodo;
        //                if (row2["idcategoria"].ToString().Equals(idcateg))
        //                {
        //                    procnodo = new TreeNode(row2["nombre"].ToString());
        //                    procnodo.Tag = row2["descripcion"].ToString();
        //                    catnode.Nodes.Add(procnodo);
        //                }
        //            }
        //            treeView1.Nodes.Add(catnode);
        //        }


        //        NuevaSecuencia = treeView2.Nodes.Add(textBox1.Text);
        //        NuevaSecuencia.Expand();


        //        //Categoria_1 = treeView1.Nodes.Add("Categoria_1");
        //        //Categoria_1.Nodes.Add("Paso_1");
        //        //Categoria_1.Nodes.Add("Paso_2");
        //        //Categoria_1.Nodes.Add("Paso_3");
        //        //Categoria_1.Expand();

        //        //Categoria_2 = treeView1.Nodes.Add("Categoria_2");
        //        //Categoria_2.Nodes.Add("Paso_1");
        //        //Categoria_2.Nodes.Add("Paso_2");
        //        //Categoria_2.Nodes.Add("Paso_3");
        //        //Categoria_2.Expand();

        //        //Categoria_3 = treeView1.Nodes.Add("Categoria_3");
        //        //Categoria_3.Nodes.Add("Paso_1");
        //        //Categoria_3.Nodes.Add("Paso_2");
        //        //Categoria_3.Nodes.Add("Paso_3");
        //        //Categoria_3.Expand();

             
        //        //this.treeView1.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeView_ItemDrag);
        //        ////this.treeView2.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeView_ItemDrag);

        //        ////this.treeView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeView_DragEnter);
        //        //this.treeView2.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeView_DragEnter);

        //        ////this.treeView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeView_DragDrop);
        //        //this.treeView2.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeView_DragDrop);
        //    }
        //}

        private void treeView_ItemDrag(object sender, System.Windows.Forms.ItemDragEventArgs e)
        {
            DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void treeView_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void treeView_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        {
            TreeNode NewNode;

            if (e.Data.GetDataPresent("System.Windows.Forms.TreeNode", false))
            {
                Point pt = ((TreeView)sender).PointToClient(new Point(e.X, e.Y));
                TreeNode DestinationNode = ((TreeView)sender).GetNodeAt(pt);
                NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");

                if (DestinationNode.TreeView != NewNode.TreeView)
                {
                    DestinationNode.Nodes.Add((TreeNode)NewNode.Clone());
                    DestinationNode.Expand();
                    //Remove Original Node
                    //NewNode.Remove();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NuevaSecuencia.Nodes.Add(treeView1.SelectedNode.Text); 
                
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RemoveCheckedNodes(treeView2.Nodes);
            Console.WriteLine(treeView2.Nodes[0].Text);
            
        }

        void RemoveCheckedNodes(TreeNodeCollection nodes)
        {
            List<TreeNode> checkedNodes = new List<TreeNode>();

            foreach (TreeNode node in nodes)
            {
                if (node.Checked)
                {
                    checkedNodes.Add(node);
                }
                else
                {
                    RemoveCheckedNodes(node.Nodes);
                }
            }

            foreach (TreeNode checkedNode in checkedNodes)
            {
                nodes.Remove(checkedNode);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (NuevaSecuencia.GetNodeCount(true) == 0)
            {
                Console.Out.WriteLine(NuevaSecuencia.GetNodeCount(true));
                MessageBox.Show("Imposible Programar Secuencia", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                List<string> secSelec = new List<string>();

                //Console.Out.WriteLine("NOM_SEC: "+NuevaSecuencia.Text); //NOM SEC
                secSelec.Add(NuevaSecuencia.Text); //metemos el Nombre de la secuenia 

                for (int i = 1; i < NuevaSecuencia.GetNodeCount(true); i++)
                {
                    secSelec.Add(NuevaSecuencia.Nodes[i].Text);
                    Console.Out.WriteLine("ELEMENT_: " + secSelec.ElementAt(i));
                }

                //PrograSec prS = new PrograSec(secSelec);
                //prS.ShowDialog();

                //Console.Out.WriteLine("NODES: "+NuevaSecuencia.Nodes.ToString());
                //Console.Out.WriteLine("LLamar Formulario 2");
                //Console.Out.WriteLine(NuevaSecuencia.GetNodeCount(true));
            }
        }

        /*Boton Guardar. Al presionarlo se debe almacenar en la tabla 
         *SECUENCIA una nueva secuencia creada por el programador. */
        private void button7_Click(object sender, EventArgs e)
        {
            /*Si entra al IF es por que no hay procesos seleccionados*/
            if (NuevaSecuencia.GetNodeCount(true) == 0)
            {
                Console.Out.WriteLine(NuevaSecuencia.GetNodeCount(true));
                MessageBox.Show("Imposible Guardar Secuencia, Ningun Proceso Seleccionado", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                /*Obtenemos la secuencia del arbol y la metemos a una Lista */
                List<string> secSelec = new List<string>();

                /*Metemos el Nombre de la secuenia */
                secSelec.Add(NuevaSecuencia.Text);
                /*Metemos los procesos seleccionados */
                for (int i = 0; i < NuevaSecuencia.GetNodeCount(true); i++)
                    secSelec.Add(NuevaSecuencia.Nodes[i].Text);
                
                /*Elementos de la Lista*/
                for(int j = 0; j < secSelec.Count;j++)
                    Console.Out.WriteLine("ELEMENT_: "+j+ secSelec.ElementAt(j));

                //guardar(secSelec); 
            }
        }

        /*Metodo Guardar para una secuencia */
        //private void guardar(List<string> secSelec)
        //{
         
        //    String ssql;
        //    //ssql = "insert into tb_secuencia(nombre,fecha_creacion,usuario_creador,tipo,descripcion,idprogramacion)";
        //    //ssql += " values(@nombre,@fecha_creacion,@usuario_creador,@tipo,@descripcion,@idprogramacion)";

        //    ssql = "insert into tb_secuencia(nombre,fecha_creacion,usuario_creador,descripcion,idprogramacion)";
        //    ssql += " values(@nombre,@fecha_creacion,@usuario_creador,@descripcion,@idprogramacion)";

        //    string connstring = ConfigurationManager.ConnectionStrings["My conexion"].ConnectionString;
        //    NpgsqlConnection conn = new NpgsqlConnection(connstring);
        //    conn.Open();

        //    //----------------
        ////--------------

        //NpgsqlCommand comm = new NpgsqlCommand(ssql, conn);

        //   // comm.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer);
        //    comm.Parameters.Add("@nombre", NpgsqlTypes.NpgsqlDbType.Varchar);
        //    comm.Parameters.Add("@fecha_creacion", NpgsqlTypes.NpgsqlDbType.Timestamp);
        //    comm.Parameters.Add("@usuario_creador", NpgsqlTypes.NpgsqlDbType.Varchar);
        //    comm.Parameters.Add("@tipo", NpgsqlTypes.NpgsqlDbType.Varchar);
        //    comm.Parameters.Add("@descripcion", NpgsqlTypes.NpgsqlDbType.Varchar);
        //    comm.Parameters.Add("@idprogramacion", NpgsqlTypes.NpgsqlDbType.Integer);


        //    //comm.Parameters["@id"].Value = 4;
        //    comm.Parameters["@nombre"].Value = "SEC_ZW221";
        //    comm.Parameters["@fecha_creacion"].Value = DateTime.Now.Date;
        //    comm.Parameters["@usuario_creador"].Value = "Raul Rodriguez G.";
        //    comm.Parameters["@tipo"].Value = "administrador";
        //    comm.Parameters["@descripcion"].Value = "Secuencia que genera reportes BANAMEX";
        //    comm.Parameters["@idprogramacion"].Value = 2;

        //    comm.ExecuteNonQuery();
        
        //}

        private void button4_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Dispose();
        }
    }
}
