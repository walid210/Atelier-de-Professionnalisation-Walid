namespace MediaTek86.Views
{
    public partial class AbsencesForm : Form
    {
        private int personnelId;

        public AbsencesForm(int personnelId)
        {
            this.personnelId = personnelId;
            InitializeComponent();
            LoadAbsences();
        }

        private void InitializeComponent()
        {
            this.dgvAbsences = new System.Windows.Forms.DataGridView();
            this.btnAddAbsence = new System.Windows.Forms.Button();
            this.btnDeleteAbsence = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAbsences
            // 
            this.dgvAbsences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbsences.Location = new System.Drawing.Point(12, 12);
            this.dgvAbsences.Name = "dgvAbsences";
            this.dgvAbsences.Size = new System.Drawing.Size(560, 300);
            this.dgvAbsences.TabIndex = 0;
            // 
            // btnAddAbsence
            // 
            this.btnAddAbsence.Location = new System.Drawing.Point(244, 330);
            this.btnAddAbsence.Name = "btnAddAbsence";
            this.btnAddAbsence.Size = new System.Drawing.Size(120, 23);
            this.btnAddAbsence.TabIndex = 1;
            this.btnAddAbsence.Text = "Ajouter Absence";
            this.btnAddAbsence.UseVisualStyleBackColor = true;
            this.btnAddAbsence.Click += new System.EventHandler(this.BtnAddAbsence_Click);
            // 
            // btnDeleteAbsence
            // 
            this.btnDeleteAbsence.Location = new System.Drawing.Point(380, 330);
            this.btnDeleteAbsence.Name = "btnDeleteAbsence";
            this.btnDeleteAbsence.Size = new System.Drawing.Size(120, 23);
            this.btnDeleteAbsence.TabIndex = 2;
            this.btnDeleteAbsence.Text = "Supprimer Absence";
            this.btnDeleteAbsence.UseVisualStyleBackColor = true;
            this.btnDeleteAbsence.Click += new System.EventHandler(this.BtnDeleteAbsence_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(506, 330);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Fermer";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // AbsencesForm
            // 
            this.ClientSize = new System.Drawing.Size(618, 361);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDeleteAbsence);
            this.Controls.Add(this.btnAddAbsence);
            this.Controls.Add(this.dgvAbsences);
            this.Name = "AbsencesForm";
            this.Text = "Gestion des Absences";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.DataGridView dgvAbsences;
        private System.Windows.Forms.Button btnAddAbsence;
        private System.Windows.Forms.Button btnDeleteAbsence;
        private System.Windows.Forms.Button btnClose;

        private void BtnDeleteAbsence_Click(object sender, EventArgs e)
        {
            if (dgvAbsences.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cette absence ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Code pour supprimer l'absence de la base de données

                    // Mise à jour de l'affichage des absences
                    LoadAbsences();
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une absence à supprimer.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadAbsences()
        {
            // Code pour charger les absences depuis la base de données et les afficher dans le DataGridView
        }
    }
}
namespace MediaTek86.Views
{
    public partial class AbsencesForm : Form
    {
        private int personnelId;

        public AbsencesForm(int personnelId)
        {
            this.personnelId = personnelId;
            InitializeComponent();
            LoadAbsences();
        }

        private void InitializeComponent()
        {
            this.dgvAbsences = new System.Windows.Forms.DataGridView();
            this.btnAddAbsence = new System.Windows.Forms.Button();
            this.btnDeleteAbsence = new System.Windows.Forms.Button();
            this.btnEditAbsence = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAbsences
            // 
            this.dgvAbsences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbsences.Location = new System.Drawing.Point(12, 12);
            this.dgvAbsences.Name = "dgvAbsences";
            this.dgvAbsences.Size = new System.Drawing.Size(560, 300);
            this.dgvAbsences.TabIndex = 0;
            // 
            // btnAddAbsence
            // 
            this.btnAddAbsence.Location = new System.Drawing.Point(188, 330);
            this.btnAddAbsence.Name = "btnAddAbsence";
            this.btnAddAbsence.Size = new System.Drawing.Size(120, 23);
            this.btnAddAbsence.TabIndex = 1;
            this.btnAddAbsence.Text = "Ajouter Absence";
            this.btnAddAbsence.UseVisualStyleBackColor = true;
            this.btnAddAbsence.Click += new System.EventHandler(this.BtnAddAbsence_Click);
            // 
            // btnDeleteAbsence
            // 
            this.btnDeleteAbsence.Location = new System.Drawing.Point(314, 330);
            this.btnDeleteAbsence.Name = "btnDeleteAbsence";
            this.btnDeleteAbsence.Size = new System.Drawing.Size(120, 23);
            this.btnDeleteAbsence.TabIndex = 2;
            this.btnDeleteAbsence.Text = "Supprimer Absence";
            this.btnDeleteAbsence.UseVisualStyleBackColor = true;
            this.btnDeleteAbsence.Click += new System.EventHandler(this.BtnDeleteAbsence_Click);
            // 
            // btnEditAbsence
            // 
            this.btnEditAbsence.Location = new System.Drawing.Point(440, 330);
            this.btnEditAbsence.Name = "btnEditAbsence";
            this.btnEditAbsence.Size = new System.Drawing.Size(120, 23);
            this.btnEditAbsence.TabIndex = 3;
            this.btnEditAbsence.Text = "Modifier Absence";
            this.btnEditAbsence.UseVisualStyleBackColor = true;
            this.btnEditAbsence.Click += new System.EventHandler(this.BtnEditAbsence_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(566, 330);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Fermer";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // AbsencesForm
            // 
            this.ClientSize = new System.Drawing.Size(678, 361);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnEditAbsence);
            this.Controls.Add(this.btnDeleteAbsence);
            this.Controls.Add(this.btnAddAbsence);
            this.Controls.Add(this.dgvAbsences);
            this.Name = "AbsencesForm";
            this.Text = "Gestion des Absences";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.DataGridView dgvAbsences;
        private System.Windows.Forms.Button btnAddAbsence;
        private System.Windows.Forms.Button btnDeleteAbsence;
        private System.Windows.Forms.Button btnEditAbsence;
        private System.Windows.Forms.Button btnClose;

        private void BtnEditAbsence_Click(object sender, EventArgs e)
        {
            if (dgvAbsences.SelectedRows.Count > 0)
            {
                // Récupérer l'ID de l'absence sélectionnée
                int absenceId = Convert.ToInt32(dgvAbsences.SelectedRows[0].Cells["ID"].Value);

                // Récupérer les informations de l'absence sélectionnée depuis la base de données
                // et les passer au formulaire d'édition
                // Par exemple :
                // Absence selectedAbsence = GetAbsenceById(absenceId);
                // EditAbsenceForm editForm = new EditAbsenceForm(selectedAbsence);
                // editForm.ShowDialog();
                // LoadAbsences(); // Recharger les absences après la modification
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une absence à modifier.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadAbsences()
        {
            // Code pour charger les absences depuis la base de données et les afficher dans le DataGridView
        }
    }
}
