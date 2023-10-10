using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections.Specialized;

namespace TP1_
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            LoadTreeView(); // Appel de la méthode pour charger l'arbre au démarrage de l'application
        }
        private string currentDirectory = string.Empty;
        private string currentFile = string.Empty;
        private void LoadTreeView()
        {
            // Crée le nœud racine de l'arbre
            TreeNode rootNode = new TreeNode("Racine");
            rootNode.Tag = "racine"; // Utilise "racine" comme étiquette (tag) du nœud racine
            treeView1.Nodes.Add(rootNode); // Ajoute le nœud racine à l'arbre

            // Parcourt tous les lecteurs disponibles sur le système
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                // Crée un nœud pour chaque lecteur
                TreeNode driveNode = new TreeNode(drive.Name);
                driveNode.Tag = drive.RootDirectory.FullName; // Stocke le chemin complet en tant qu'étiquette

                // Détection des lecteurs de SSD
                if (drive.DriveType == DriveType.Fixed)
                {
                    // Associe l'indice de l'image pour les lecteurs de DVD/CD
                    driveNode.ImageIndex = 1; // Indice de l'image pour les lecteurs de DVD/CD
                    driveNode.SelectedImageIndex = 1;
                }
                // Détection des lecteurs de USB
                else if (drive.DriveType == DriveType.Removable)
                {
                    // Associe l'indice de l'image pour les lecteurs de DVD/CD
                    driveNode.ImageIndex = 4; // Indice de l'image pour les lecteurs de DVD/CD
                    driveNode.SelectedImageIndex = 4;
                }
                else
                {
                    // Associe l'indice de l'image par défaut pour les autres lecteurs
                    driveNode.ImageIndex = 0; // Indice de l'image par défaut
                    driveNode.SelectedImageIndex = 0;
                }

                // Ajoute le nœud du lecteur au nœud racine de l'arbre
                rootNode.Nodes.Add(driveNode);

                LoadDirectories(driveNode);
            }
        }

        private void LoadListView(string path)
        {
            listView1.Items.Clear();
            DirectoryInfo dirInfo = new DirectoryInfo(path);

            try
            {
                foreach (FileInfo file in dirInfo.GetFiles())
                {
                    ListViewItem item = new ListViewItem(file.Name);

                    item.Tag = path + "\\" + file.Name;
                    item.SubItems.Add(file.LastWriteTime.ToShortDateString().ToString());
                    item.SubItems.Add(file.Length.ToString());
                    if (file.Extension == ".docx")
                    {
                        item.ImageIndex = 12;
                    }
                    else if (file.Extension == ".pdf")
                    {
                        item.ImageIndex = 20;
                    }
                    else if (file.Extension == ".zip")
                    {
                        item.ImageIndex = 90;
                    }
                    else
                    {
                        item.ImageIndex = 5;
                    }

                    listView1.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void quittezToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Ferme l'application lorsque l'option "Quittez" est sélectionnée
        }

        private void LoadDirectories(TreeNode parentNode)
        {
            try
            {
                string path = parentNode.Tag.ToString();
                DirectoryInfo dirInfo = new DirectoryInfo(path);

                foreach (DirectoryInfo dir in dirInfo.GetDirectories())
                {
                    TreeNode dirNode = new TreeNode(dir.Name);
                    dirNode.Tag = dir.FullName;
                    parentNode.Nodes.Add(dirNode);
                    dirNode.ImageIndex = 2; // Icône de dossier
                    dirNode.SelectedImageIndex = 2;
                    dirNode.Nodes.Add(""); // Ajoute un nœud vide pour afficher le signe "+"
                }
            }
            catch (Exception ex)
            {
                // Gère toutes les exceptions (par exemple, accès refusé)
                MessageBox.Show(ex.Message);
            }
        }

        private bool HasSubDirectories(TreeNode node)
        {
            try
            {
                string directoryPath = node.Tag.ToString();
                DirectoryInfo directoryInfo = new DirectoryInfo(directoryPath);

                DirectoryInfo[] subDirectories = directoryInfo.GetDirectories();

                return subDirectories.Length > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de la vérification des sous-répertoires : " + ex.Message);
                return false;
            }
        }

        private void clearTreeViewButton_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear(); // Vider la collection de nœuds du TreeView
        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode selectedNode = e.Node;

            // Vérifiez si le nœud est déjà marqué comme ayant été chargé (en supprimant le nœud racine vide)
            if (selectedNode.Nodes.Count == 1 && selectedNode.Nodes[0].Text == "")
            {
                selectedNode.Nodes.Clear(); // Supprime le nœud racine vide
                LoadDirectories(selectedNode); // Chargez les répertoires réels
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Level > 0)
            {
                LoadListView(e.Node.Tag.ToString());
                currentDirectory = e.Node.Tag.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }

        private void List_Click(object sender, EventArgs e)
        {
            listView1.View = View.List;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selected = listView1.SelectedItems[0];
                string selectedItemPath = selected.Tag.ToString(); // Récupère le chemin complet de l'élément sélectionné
                string lastModifTime = selected.SubItems[1].Text; // Récupère la date de dernière modification
                string length = selected.SubItems[2].Text; // Récupère la taille du fichier

                // Affichage des informations dans les zones de texte
                textBox1.Text = selectedItemPath; // Affiche le chemin complet
                textBox2.Text = lastModifTime; // Affiche la date de dernière modification
                int intLength = int.Parse(length); // Convertit la taille en entier

                if (intLength / 1000000 > 1)
                {
                    textBox3.Text = intLength / 1000000 + "Mo"; // Affiche la taille en Mo si supérieure à 1 Mo
                }
                else
                {
                    textBox3.Text = intLength / 1000 + "Ko"; // Sinon, affiche la taille en Ko
                }

                // Stocker le chemin du fichier pour qu'il soit accessible partout 
                currentFile = selectedItemPath;
            }
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Vérifiez si un élément de la ListView a été cliqué
                ListViewHitTestInfo hitTestInfo = listView1.HitTest(e.X, e.Y);
                if (hitTestInfo.Item != null)
                {
                    // Affiche le menu contextuel à la position du clic de souris
                    contextMenuStrip1.Show(listView1, e.Location);
                }
                else
                {
                    contextMenuStrip2.Show(listView1, e.Location);
                }
            }
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem selected = listView1.SelectedItems[0];
                FileInfo deletedItem = new FileInfo(selected.Tag.ToString());
                DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer ce fichier ?", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    deletedItem.Delete();
                    LoadListView(currentDirectory);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void collerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringCollection pastedFiles = new StringCollection();

            pastedFiles = Clipboard.GetFileDropList();

            FileInfo item = new FileInfo(pastedFiles[0]);
            string destinationDirectory = currentDirectory;

            // Parcourez les fichiers à coller
            try
            {
                // Créez un objet FileInfo pour le fichier source
                FileInfo sourceFile = new FileInfo(pastedFiles[0]);

                // Créez le chemin complet de destination en concaténant le chemin du répertoire de destination et le nom de fichier
                string destinationFilePath = Path.Combine(destinationDirectory, sourceFile.Name);

                // Copiez le fichier source vers le répertoire de destination
                sourceFile.CopyTo(destinationFilePath);

                // Rafraîchissez la ListView pour afficher le fichier copié
                LoadListView(destinationDirectory);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur lors de la copie du fichier", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void copierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringCollection copiedFiles = new StringCollection();
            copiedFiles.Add(currentFile);
            Clipboard.SetFileDropList(copiedFiles);
        }

        private void treeView1_DragDrop(object sender, DragEventArgs e)
        {
            //  node de destination dans le TreeView
            TreeNode destinationNode = treeView1.GetNodeAt(treeView1.PointToClient(new Point(e.X, e.Y)));

            // Vérif si un node de destination a été trouvé
            if (destinationNode != null)
            {
                // Get l'élément ListViewItem depuis les données de l'événement de "Drag and Drop"
                ListViewItem draggedItem = (ListViewItem)e.Data.GetData(typeof(ListViewItem));

                // Get les chemins source et de destination
                string sourcePath = draggedItem.Tag.ToString();
                string destinationPath = Path.Combine(destinationNode.Tag.ToString(), draggedItem.Text);

                try
                {
                    // Déplacer le fichier source vers le répertoire de destination
                    File.Move(sourcePath, destinationPath);

                    // Rafraîchir la ListView
                    LoadListView(destinationNode.Tag.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur lors du déplacement du fichier", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void treeView1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void listView1_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void listView1_ItemDrag(object sender, ItemDragEventArgs e)
        {
            DoDragDrop(e.Item, DragDropEffects.Move);
        }
    }
}
