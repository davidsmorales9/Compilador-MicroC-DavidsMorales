namespace MicroC_Compiler
{
    //Se importan los espacios de nombres necesarios para la funcionalidad del formulario, manejo de archivos y procesos.
    using System.Diagnostics;
    using System.IO;
    using System.Runtime.CompilerServices;
    using System.Threading.Channels;

    public partial class MicroC_Compiler : Form
    {
        //Instancias de las clases fileManager y Compiler para manejar la gestión de archivos y la compilación del código.
        fileManager gestor = new fileManager();
        Compiler compiler = new Compiler();


        //Variables para controlar el estado del archivo actual (nuevo, cambios sin guardar, ruta actual)
        bool bNew = true;
        bool checkChanges = false;
        string currentPath = "";

        //Constructor del formulario, se maneja el evento FormClosing para detectar cuando el usuario intenta
        //cerrar la aplicación y preguntar si desea guardar los cambios antes de salir.
        public MicroC_Compiler()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
        }

        //Evento que se muestra cuando el usuario intenta cerrar la aplicación. 
        //Si hay cambios sin guardar, se mostrará un mensaje de confirmación preguntando si desea guardar los cambios antes de salir.
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            if (!checkChanges)
                return;

            DialogResult result = MessageBox.Show(
                "There are unsaved changes. Do you want to save them before exiting?","Confirm",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Warning);

            if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
                return;
            }

            if (result == DialogResult.Yes)
            {
                bool guardado = saveInternalFile();

                if (!guardado)
                {
                    e.Cancel = true;
                }
            }
        }

        //Método para guardar el archivo actual, si es un nuevo archivo o no tiene una ruta asignada,
        //se abrirá un SaveFileDialog para que el usuario elija dónde guardar el archivo.
        //Si el archivo ya tiene una ruta, se guardará directamente sin mostrar el diálogo.
        private bool saveInternalFile()
        {
            if (bNew || string.IsNullOrEmpty(currentPath))
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Archivos C (*.c)|*.c";
                saveFileDialog.Title = "Guardar archivo MicroC";

                if (saveFileDialog.ShowDialog() != DialogResult.OK)
                    return false;

                currentPath = saveFileDialog.FileName;
                bNew = false;
            }

            File.WriteAllText(currentPath, txtEditor.Text);
            checkChanges = false;
            this.Text = "MicroC Compiler - " + currentPath;

            return true;
        }

        //Método para detectar cambios en el TextBox del editor y actualizar el título de la ventana
        private void txtEditor_TextChanged(object sender, EventArgs e)
        {
            if (!txtEditor.ReadOnly)
                checkChanges = true;
            this.Text = "Changes detected";

        }

        //Método para compilar el código, muestra el resultado en el TextBox2
        //La lógica no ha sido desarrollada. Solo mostrará el mensaje "Compiling..." por ahora. 
        private void btnCompile(object sender, EventArgs e)
        {
            string result = compiler.Compile(txtEditor.Text);
            txtOutput.Text = result;
        }


        // Método para crear un nuevo archivo ".C"
        private void btnNew(object sender, EventArgs e)
        {
            if (checkChanges)
            {
                DialogResult result = MessageBox.Show("There are unsaved changes. Do you want to save them before exiting?", "Warning",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    btnSave(sender, e);
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
            }
            // Limpia el editor
            txtEditor.Clear();

            // Habilita la edición cuando se abre un archivo ".C"
            txtEditor.ReadOnly = false;

            // Resetear variables 
            bNew = true;
            checkChanges = false;
            currentPath = "";

            // Cambiar título
            this.Text = "MicroC Compiler - Nuevo archivo";

            txtOutput.Clear();
        }

        //Método para abrir un archivo ".C"
        private void btnOpen(object sender, EventArgs e)
        {

            if (checkChanges)
            {
                DialogResult result = MessageBox.Show("There are unsaved changes. Do you want to save them before exiting?", "Warning",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Warning);

                //Condicional para guardar los cambios antes de abrir un nuevo archivo
                if (result == DialogResult.Yes)
                {
                    btnSave(sender, e);
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
            }

            //Abre el cuadro de diálogo para seleccionar un archivo ".C"
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos C (*.c)|*.c";
            openFileDialog.Title = "Abrir archivo MicroC";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                currentPath = openFileDialog.FileName;

                txtEditor.Text = File.ReadAllText(currentPath);

                txtEditor.ReadOnly = true;

                bNew = false;
                checkChanges = false;

                this.Text = "MicroC Compiler - " + currentPath;

                txtOutput.Clear();
            }
        }

        //Método para guardar el archivo actual
        private void btnSave(object sender, EventArgs e)
        {
            saveInternalFile();
        }

        //Método para salir de la aplicación
        private void btnExit(object sender, EventArgs e)
        {
            this.Close();
        }

        //Método para mostrar el archivo de ayuda "Pre-COMPILADOR.pdf"
        private void btnHelp(object sender, EventArgs e)
        {
            string path = Path.Combine(Application.StartupPath, "Pre-COMPILADOR.pdf");

            if (File.Exists(path))
            {
                Process.Start(new ProcessStartInfo()
                {
                    FileName = path,
                    UseShellExecute = true
                });
            }
            else
            {
                MessageBox.Show("The help file was not found.", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        //Método para habilitar la edición cuando se abre un archivo ".C" en modo de solo lectura       
        private void btnEnableEd(object sender, EventArgs e)
        {
            if (txtEditor.ReadOnly)
            {
                txtEditor.ReadOnly = false;
                MessageBox.Show("Editing enabled. You can now modify the code.", "Editing enabled",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Editing is now enabled.", "Editing now enabled", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}