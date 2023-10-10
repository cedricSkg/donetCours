namespace TP1_
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.applicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quittezToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.List = new System.Windows.Forms.Button();
            this.smallIcon = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.emplacement = new System.Windows.Forms.Label();
            this.ddm = new System.Windows.Forms.Label();
            this.taille = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.collerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // applicationToolStripMenuItem
            // 
            this.applicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quittezToolStripMenuItem});
            this.applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            this.applicationToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.applicationToolStripMenuItem.Text = "Application";
            // 
            // quittezToolStripMenuItem
            // 
            this.quittezToolStripMenuItem.Name = "quittezToolStripMenuItem";
            this.quittezToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.quittezToolStripMenuItem.Text = "Quittez";
            this.quittezToolStripMenuItem.Click += new System.EventHandler(this.quittezToolStripMenuItem_Click);
            // 
            // treeView1
            // 
            this.treeView1.AllowDrop = true;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(34, 69);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(293, 344);
            this.treeView1.TabIndex = 1;
            this.treeView1.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeExpand);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeView1_DragDrop);
            this.treeView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeView1_DragEnter);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Computer-icon.png");
            this.imageList1.Images.SetKeyName(1, "vista-023.ico");
            this.imageList1.Images.SetKeyName(2, "blanc-fichier-un-dossier-icone-9522-16.png");
            this.imageList1.Images.SetKeyName(3, "logo-3il-part.png");
            this.imageList1.Images.SetKeyName(4, "USB-icon - Copie.png");
            this.imageList1.Images.SetKeyName(5, "application-un-fichier-icone-6489-16.png");
            this.imageList1.Images.SetKeyName(6, "USB-icon.png");
            this.imageList1.Images.SetKeyName(7, "app-x-yaml-icon (1).png");
            this.imageList1.Images.SetKeyName(8, "app-x-yaml-icon (2).png");
            this.imageList1.Images.SetKeyName(9, "app-x-yaml-icon (3).png");
            this.imageList1.Images.SetKeyName(10, "app-x-yaml-icon.png");
            this.imageList1.Images.SetKeyName(11, "doc-icon (1).png");
            this.imageList1.Images.SetKeyName(12, "doc-icon.png");
            this.imageList1.Images.SetKeyName(13, "docx-icon (1).png");
            this.imageList1.Images.SetKeyName(14, "docx-icon.png");
            this.imageList1.Images.SetKeyName(15, "jpeg-image-icon (1).png");
            this.imageList1.Images.SetKeyName(16, "jpeg-image-icon (2).png");
            this.imageList1.Images.SetKeyName(17, "jpeg-image-icon.png");
            this.imageList1.Images.SetKeyName(18, "pdf-icon (1).png");
            this.imageList1.Images.SetKeyName(19, "pdf-icon (2).png");
            this.imageList1.Images.SetKeyName(20, "pdf-icon.png");
            this.imageList1.Images.SetKeyName(21, "txt-icon (1).png");
            this.imageList1.Images.SetKeyName(22, "txt-icon (2).png");
            this.imageList1.Images.SetKeyName(23, "txt-icon.png");
            this.imageList1.Images.SetKeyName(24, "xlsx-icon (1).png");
            this.imageList1.Images.SetKeyName(25, "xlsx-icon (2).png");
            this.imageList1.Images.SetKeyName(26, "xlsx-icon.png");
            this.imageList1.Images.SetKeyName(27, "icon_accueil.png");
            this.imageList1.Images.SetKeyName(28, "inav.bmp");
            this.imageList1.Images.SetKeyName(29, "irefresh.bmp");
            this.imageList1.Images.SetKeyName(30, "open.bmp");
            this.imageList1.Images.SetKeyName(31, "save.bmp");
            this.imageList1.Images.SetKeyName(32, "icon1 - Copie.png");
            this.imageList1.Images.SetKeyName(33, "icon1.png");
            this.imageList1.Images.SetKeyName(34, "icon2.png");
            this.imageList1.Images.SetKeyName(35, "icon3.bmp");
            this.imageList1.Images.SetKeyName(36, "icon4.bmp");
            this.imageList1.Images.SetKeyName(37, "icone_precedent.png");
            this.imageList1.Images.SetKeyName(38, "icon-up-images.png");
            this.imageList1.Images.SetKeyName(39, "vista-123.ico");
            this.imageList1.Images.SetKeyName(40, "vista-124.ico");
            this.imageList1.Images.SetKeyName(41, "liste.png");
            this.imageList1.Images.SetKeyName(42, "vista-013.ico");
            this.imageList1.Images.SetKeyName(43, "vista-014.ico");
            this.imageList1.Images.SetKeyName(44, "vista-015.ico");
            this.imageList1.Images.SetKeyName(45, "vista-016.ico");
            this.imageList1.Images.SetKeyName(46, "vista-017.ico");
            this.imageList1.Images.SetKeyName(47, "vista-018.ico");
            this.imageList1.Images.SetKeyName(48, "vista-019.ico");
            this.imageList1.Images.SetKeyName(49, "vista-020.ico");
            this.imageList1.Images.SetKeyName(50, "vista-021.ico");
            this.imageList1.Images.SetKeyName(51, "vista-022.ico");
            this.imageList1.Images.SetKeyName(52, "vista-024.ico");
            this.imageList1.Images.SetKeyName(53, "vista-025.ico");
            this.imageList1.Images.SetKeyName(54, "vista-026.ico");
            this.imageList1.Images.SetKeyName(55, "vista-027.ico");
            this.imageList1.Images.SetKeyName(56, "vista-028.ico");
            this.imageList1.Images.SetKeyName(57, "vista-029.ico");
            this.imageList1.Images.SetKeyName(58, "vista-030.ico");
            this.imageList1.Images.SetKeyName(59, "vista-031.ico");
            this.imageList1.Images.SetKeyName(60, "vista-032.ico");
            this.imageList1.Images.SetKeyName(61, "vista-033.ico");
            this.imageList1.Images.SetKeyName(62, "vista-034.ico");
            this.imageList1.Images.SetKeyName(63, "vista-035.ico");
            this.imageList1.Images.SetKeyName(64, "vista-036.ico");
            this.imageList1.Images.SetKeyName(65, "vista-037.ico");
            this.imageList1.Images.SetKeyName(66, "vista-038.ico");
            this.imageList1.Images.SetKeyName(67, "vista-039.ico");
            this.imageList1.Images.SetKeyName(68, "vista-040.ico");
            this.imageList1.Images.SetKeyName(69, "vista-041.ico");
            this.imageList1.Images.SetKeyName(70, "vista-042.ico");
            this.imageList1.Images.SetKeyName(71, "vista-043.ico");
            this.imageList1.Images.SetKeyName(72, "vista-044.ico");
            this.imageList1.Images.SetKeyName(73, "vista-045.ico");
            this.imageList1.Images.SetKeyName(74, "vista-046.ico");
            this.imageList1.Images.SetKeyName(75, "vista-047.ico");
            this.imageList1.Images.SetKeyName(76, "vista-048.ico");
            this.imageList1.Images.SetKeyName(77, "vista-121.ico");
            this.imageList1.Images.SetKeyName(78, "vista-122.ico");
            this.imageList1.Images.SetKeyName(79, "application-un-fichier-icone-6489-32.png");
            this.imageList1.Images.SetKeyName(80, "arrow-disque-telecharger-disque-dur-hdd-icone-7580-16.png");
            this.imageList1.Images.SetKeyName(81, "arrow-disque-telecharger-disque-dur-hdd-icone-7580-32.png");
            this.imageList1.Images.SetKeyName(82, "blanc-fichier-un-dossier-icone-9522-32.png");
            this.imageList1.Images.SetKeyName(83, "disque-go-icone-8759-16.png");
            this.imageList1.Images.SetKeyName(84, "disque-go-icone-8759-32.png");
            this.imageList1.Images.SetKeyName(85, "document-bleu-fichier-g98-papier-icone-9569-16.png");
            this.imageList1.Images.SetKeyName(86, "document-bleu-fichier-g98-papier-icone-9569-32.png");
            this.imageList1.Images.SetKeyName(87, "document-un-fichier-icone-9015-16.png");
            this.imageList1.Images.SetKeyName(88, "document-un-fichier-icone-9015-32.png");
            this.imageList1.Images.SetKeyName(89, "dossier-de-la-page-icone-5144-16.png");
            this.imageList1.Images.SetKeyName(90, "dossier-de-la-page-icone-5144-32.png");
            this.imageList1.Images.SetKeyName(91, "dossier-vert-icone-6633-16.png");
            this.imageList1.Images.SetKeyName(92, "dossier-vert-icone-6633-32.png");
            this.imageList1.Images.SetKeyName(93, "dossier-vert-ouvert-icone-8269-16.png");
            this.imageList1.Images.SetKeyName(94, "dossier-vert-ouvert-icone-8269-128.png");
            this.imageList1.Images.SetKeyName(95, "dvd-go-icone-5554-16.png");
            this.imageList1.Images.SetKeyName(96, "dvd-go-icone-5554-32.png");
            this.imageList1.Images.SetKeyName(97, "fichier-depot-un-dossier-complet-papier-icone-3848-16.png");
            this.imageList1.Images.SetKeyName(98, "fichier-depot-un-dossier-complet-papier-icone-3848-32.png");
            this.imageList1.Images.SetKeyName(99, "fichier-windows-icone-9317-16.png");
            this.imageList1.Images.SetKeyName(100, "fichier-windows-icone-9317-32.png");
            this.imageList1.Images.SetKeyName(101, "hd-fenetres-icone-4421-16.png");
            this.imageList1.Images.SetKeyName(102, "hd-fenetres-icone-4421-32.png");
            this.imageList1.Images.SetKeyName(103, "lecteur-dvd-dvd-icone-9537-16.png");
            this.imageList1.Images.SetKeyName(104, "lecteur-dvd-dvd-icone-9537-32.png");
            this.imageList1.Images.SetKeyName(105, "lecteur-optique-icone-8106-16.png");
            this.imageList1.Images.SetKeyName(106, "lecteur-optique-icone-8106-32.png");
            this.imageList1.Images.SetKeyName(107, "ordinateur-pc-icone-6183-16.png");
            this.imageList1.Images.SetKeyName(108, "ordinateur-pc-icone-6183-48.png");
            this.imageList1.Images.SetKeyName(109, "042.ICO");
            this.imageList1.Images.SetKeyName(110, "043.ICO");
            this.imageList1.Images.SetKeyName(111, "119.ICO");
            this.imageList1.Images.SetKeyName(112, "CD-ROM Drive.ico");
            this.imageList1.Images.SetKeyName(113, "CRDFLE07.ICO");
            this.imageList1.Images.SetKeyName(114, "DRAG2PG.ICO");
            this.imageList1.Images.SetKeyName(115, "DRIVE.ICO");
            this.imageList1.Images.SetKeyName(116, "DRIVE-C1.ICO");
            this.imageList1.Images.SetKeyName(117, "Empty Recycle Bin.ico");
            this.imageList1.Images.SetKeyName(118, "EXPLORER.ICO");
            this.imageList1.Images.SetKeyName(119, "FOLDER04.ICO");
            this.imageList1.Images.SetKeyName(120, "INSDISK.ICO");
            this.imageList1.Images.SetKeyName(121, "network.bmp");
            this.imageList1.Images.SetKeyName(122, "network.png");
            // 
            // listView1
            // 
            this.listView1.AllowDrop = true;
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(345, 69);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(425, 257);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.listView1_ItemDrag);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.DragOver += new System.Windows.Forms.DragEventHandler(this.listView1_DragOver);
            this.listView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // List
            // 
            this.List.Location = new System.Drawing.Point(606, 40);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(51, 23);
            this.List.TabIndex = 3;
            this.List.Text = "List";
            this.List.UseVisualStyleBackColor = true;
            this.List.Click += new System.EventHandler(this.List_Click);
            // 
            // smallIcon
            // 
            this.smallIcon.Location = new System.Drawing.Point(663, 40);
            this.smallIcon.Name = "smallIcon";
            this.smallIcon.Size = new System.Drawing.Size(50, 23);
            this.smallIcon.TabIndex = 4;
            this.smallIcon.Text = "Small";
            this.smallIcon.UseVisualStyleBackColor = true;
            this.smallIcon.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(719, 40);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(51, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Large";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // emplacement
            // 
            this.emplacement.AutoSize = true;
            this.emplacement.Location = new System.Drawing.Point(373, 345);
            this.emplacement.Name = "emplacement";
            this.emplacement.Size = new System.Drawing.Size(80, 13);
            this.emplacement.TabIndex = 6;
            this.emplacement.Text = "Emplacement : ";
            // 
            // ddm
            // 
            this.ddm.AutoSize = true;
            this.ddm.Location = new System.Drawing.Point(373, 378);
            this.ddm.Name = "ddm";
            this.ddm.Size = new System.Drawing.Size(154, 13);
            this.ddm.TabIndex = 7;
            this.ddm.Text = "Date de dernière modification : ";
            // 
            // taille
            // 
            this.taille.AutoSize = true;
            this.taille.Location = new System.Drawing.Point(660, 378);
            this.taille.Name = "taille";
            this.taille.Size = new System.Drawing.Size(41, 13);
            this.taille.TabIndex = 8;
            this.taille.Text = "Taille : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(460, 345);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(310, 20);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(533, 374);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(94, 20);
            this.textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(700, 373);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(70, 20);
            this.textBox3.TabIndex = 11;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supprimerToolStripMenuItem,
            this.copierToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(130, 48);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // copierToolStripMenuItem
            // 
            this.copierToolStripMenuItem.Name = "copierToolStripMenuItem";
            this.copierToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copierToolStripMenuItem.Text = "Copier";
            this.copierToolStripMenuItem.Click += new System.EventHandler(this.copierToolStripMenuItem_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.collerToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(106, 26);
            // 
            // collerToolStripMenuItem
            // 
            this.collerToolStripMenuItem.Name = "collerToolStripMenuItem";
            this.collerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.collerToolStripMenuItem.Text = "Coller";
            this.collerToolStripMenuItem.Click += new System.EventHandler(this.collerToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.taille);
            this.Controls.Add(this.ddm);
            this.Controls.Add(this.emplacement);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.smallIcon);
            this.Controls.Add(this.List);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem applicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quittezToolStripMenuItem;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button List;
        private System.Windows.Forms.Button smallIcon;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label emplacement;
        private System.Windows.Forms.Label ddm;
        private System.Windows.Forms.Label taille;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copierToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem collerToolStripMenuItem;
    }
}

