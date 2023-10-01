using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Web;

namespace GridView_ADO.NET
{
    public partial class Form1 : Form
    {
        DataTable? table = null;
        DataSet? dataSet = null;
        SqlConnection? connection = null;
        DbDataAdapter? adapter = null;
        SqlCommand? cmd = null;
        SqlDataReader? reader = null;


        public Form1()
        {
            InitializeComponent();
            string conStr = "Data Source=DESKTOP-IBRAHIM\\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True;";
            connection = new SqlConnection(conStr);
        }

        public void WorkingDataTable()
        {
            //DataTable
            //DataSet
            table = new DataTable();
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("FirstName", typeof(string));
            table.Columns.Add("LastName", typeof(string));
            table.Rows.Add(1, "Ibrahim", "Asadov");
            table.Rows.Add(2, "Hesen", "Abdullazade");

            dataGridView1.DataSource = table;
        }
        private void ReadDataConnectionMode()
        {
            try
            {
                connection!.Open();
                string query = textBox1.Text;
                cmd = new SqlCommand(query, connection);
                reader = cmd.ExecuteReader();
                table = new DataTable();

                bool isColumnName = true;
                do
                    while (reader.Read())
                    {
                        if (isColumnName)
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                table.Columns.Add(reader.GetName(i));
                            }
                        }
                        isColumnName = false;
                        DataRow newRow = table.NewRow();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            newRow[i] = reader[i];
                        }
                        table.Rows.Add(newRow);

                    } while (reader.NextResult());
                dataGridView1.DataSource = table;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {

                connection!.Close();
            }
        }
        private void ReadDataDisconnectedMode()
        {
            try
            {

                string selectQuery = "SELECT * FROM Authors";

                dataSet = new DataSet();
                adapter = new SqlDataAdapter(selectQuery, connection);
                adapter.Fill(dataSet); //open,close,write

                dataGridView1.DataSource = dataSet.Tables[0];


            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection!.Close();
            }
        }
        private void ReadDataDisConnectedModeWithSqlCommandBuilder()
        {
            try
            {

                string selectQuery = "SELECT * FROM Authors";

                dataSet = new DataSet();
                adapter = new SqlDataAdapter(selectQuery, connection);
                adapter.Fill(dataSet);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder((SqlDataAdapter)adapter);
                dataGridView1.DataSource= dataSet.Tables["tables"];


            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection!.Close();
            }
        }
        private void CustomUpdateCommand()
        {
            string selectSQL = "SELECT * FROM Books";
            adapter = new SqlDataAdapter(selectSQL,connection);

            dataSet = new DataSet();
            adapter.Fill(dataSet, "myTable");


            //// Way 1
            SqlCommand updateCommand = new SqlCommand("UPDATE Books SET Pages=@pPages WHERE Id=@pId", connection);


            //// Way 2
        

            updateCommand.Parameters.Add(new SqlParameter("@pId", SqlDbType.Int));
            updateCommand.Parameters["@pId"].SourceVersion = DataRowVersion.Original;
            updateCommand.Parameters["@pId"].SourceColumn = "Id";

            updateCommand.Parameters.Add(new SqlParameter("@pPages", SqlDbType.Int));
            updateCommand.Parameters["@pPages"].SourceVersion = DataRowVersion.Current;
            updateCommand.Parameters["@pPages"].SourceColumn = "Pages";

            adapter!.UpdateCommand = updateCommand;

            dataGridView1.DataSource = dataSet.Tables[0];

            MessageBox.Show(adapter.UpdateCommand.CommandText);
        }
        private void execButton_Click(object sender, EventArgs e)
        {
            //WorkingDataTable();
            ReadDataConnectionMode();
        }

        private void fillButton_Click(object sender, EventArgs e)
        {
            //ReadDataDisconnectedMode();
            CustomUpdateCommand();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Salam");
            if(dataSet is not null)
            {
                MessageBox.Show("Salam");
                adapter!.Update(dataSet);
            }
        }
    }
}