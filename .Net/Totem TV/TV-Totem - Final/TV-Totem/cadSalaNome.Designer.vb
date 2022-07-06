<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cadSalaNome
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim NomeLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cadSalaNome))
        Me.btSalvarNomeSala = New System.Windows.Forms.Button()
        Me.btApagarSala = New System.Windows.Forms.Button()
        Me.btNovaSala = New System.Windows.Forms.Button()
        Me.CodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.btDesfazer = New System.Windows.Forms.Button()
        Me.btEditarNomeSala = New System.Windows.Forms.Button()
        Me.btSair = New System.Windows.Forms.Button()
        Me.DadosDataSet = New TV_Totem.DadosDataSet()
        Me.SalasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalasTableAdapter = New TV_Totem.DadosDataSetTableAdapters.SalasTableAdapter()
        Me.TableAdapterManager = New TV_Totem.DadosDataSetTableAdapters.TableAdapterManager()
        Me.SalasBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalasDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        NomeLabel = New System.Windows.Forms.Label()
        CType(Me.DadosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SalasBindingNavigator.SuspendLayout()
        CType(Me.SalasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Location = New System.Drawing.Point(11, 44)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(77, 13)
        NomeLabel.TabIndex = 5
        NomeLabel.Text = "Nome da Sala:"
        '
        'btSalvarNomeSala
        '
        Me.btSalvarNomeSala.Location = New System.Drawing.Point(146, 325)
        Me.btSalvarNomeSala.Name = "btSalvarNomeSala"
        Me.btSalvarNomeSala.Size = New System.Drawing.Size(61, 50)
        Me.btSalvarNomeSala.TabIndex = 0
        Me.btSalvarNomeSala.Text = "Salvar"
        Me.btSalvarNomeSala.UseVisualStyleBackColor = True
        '
        'btApagarSala
        '
        Me.btApagarSala.Location = New System.Drawing.Point(213, 325)
        Me.btApagarSala.Name = "btApagarSala"
        Me.btApagarSala.Size = New System.Drawing.Size(61, 50)
        Me.btApagarSala.TabIndex = 2
        Me.btApagarSala.Text = "Apagar"
        Me.btApagarSala.UseVisualStyleBackColor = True
        '
        'btNovaSala
        '
        Me.btNovaSala.Location = New System.Drawing.Point(14, 325)
        Me.btNovaSala.Name = "btNovaSala"
        Me.btNovaSala.Size = New System.Drawing.Size(61, 50)
        Me.btNovaSala.TabIndex = 3
        Me.btNovaSala.Text = "Novo"
        Me.btNovaSala.UseVisualStyleBackColor = True
        '
        'CodigoDataGridViewTextBoxColumn
        '
        Me.CodigoDataGridViewTextBoxColumn.DataPropertyName = "codigo"
        Me.CodigoDataGridViewTextBoxColumn.HeaderText = "codigo"
        Me.CodigoDataGridViewTextBoxColumn.Name = "CodigoDataGridViewTextBoxColumn"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 23)
        '
        'btDesfazer
        '
        Me.btDesfazer.Location = New System.Drawing.Point(79, 325)
        Me.btDesfazer.Name = "btDesfazer"
        Me.btDesfazer.Size = New System.Drawing.Size(61, 50)
        Me.btDesfazer.TabIndex = 15
        Me.btDesfazer.Text = "Desfazer"
        Me.btDesfazer.UseVisualStyleBackColor = True
        '
        'btEditarNomeSala
        '
        Me.btEditarNomeSala.Location = New System.Drawing.Point(79, 325)
        Me.btEditarNomeSala.Name = "btEditarNomeSala"
        Me.btEditarNomeSala.Size = New System.Drawing.Size(61, 50)
        Me.btEditarNomeSala.TabIndex = 14
        Me.btEditarNomeSala.Text = "Editar"
        Me.btEditarNomeSala.UseVisualStyleBackColor = True
        '
        'btSair
        '
        Me.btSair.Location = New System.Drawing.Point(324, 325)
        Me.btSair.Name = "btSair"
        Me.btSair.Size = New System.Drawing.Size(61, 50)
        Me.btSair.TabIndex = 16
        Me.btSair.Text = "Sair"
        Me.btSair.UseVisualStyleBackColor = True
        '
        'DadosDataSet
        '
        Me.DadosDataSet.DataSetName = "DadosDataSet"
        Me.DadosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SalasBindingSource
        '
        Me.SalasBindingSource.DataMember = "Salas"
        Me.SalasBindingSource.DataSource = Me.DadosDataSet
        '
        'SalasTableAdapter
        '
        Me.SalasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EventosTableAdapter = Nothing
        Me.TableAdapterManager.SalasTableAdapter = Me.SalasTableAdapter
        Me.TableAdapterManager.UpdateOrder = TV_Totem.DadosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SalasBindingNavigator
        '
        Me.SalasBindingNavigator.AddNewItem = Nothing
        Me.SalasBindingNavigator.BindingSource = Me.SalasBindingSource
        Me.SalasBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.SalasBindingNavigator.DeleteItem = Nothing
        Me.SalasBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.SalasBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.SalasBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.SalasBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.SalasBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.SalasBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.SalasBindingNavigator.Name = "SalasBindingNavigator"
        Me.SalasBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.SalasBindingNavigator.Size = New System.Drawing.Size(418, 25)
        Me.SalasBindingNavigator.TabIndex = 17
        Me.SalasBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'SalasDataGridView
        '
        Me.SalasDataGridView.AutoGenerateColumns = False
        Me.SalasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SalasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2})
        Me.SalasDataGridView.DataSource = Me.SalasBindingSource
        Me.SalasDataGridView.Location = New System.Drawing.Point(14, 83)
        Me.SalasDataGridView.Name = "SalasDataGridView"
        Me.SalasDataGridView.Size = New System.Drawing.Size(371, 220)
        Me.SalasDataGridView.TabIndex = 17
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nome"
        Me.DataGridViewTextBoxColumn2.HeaderText = "nome"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 310
        '
        'NomeTextBox
        '
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalasBindingSource, "nome", True))
        Me.NomeTextBox.Location = New System.Drawing.Point(94, 41)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(291, 20)
        Me.NomeTextBox.TabIndex = 18
        '
        'cadSalaNome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 401)
        Me.Controls.Add(Me.NomeTextBox)
        Me.Controls.Add(Me.SalasDataGridView)
        Me.Controls.Add(Me.SalasBindingNavigator)
        Me.Controls.Add(Me.btSair)
        Me.Controls.Add(Me.btEditarNomeSala)
        Me.Controls.Add(NomeLabel)
        Me.Controls.Add(Me.btNovaSala)
        Me.Controls.Add(Me.btApagarSala)
        Me.Controls.Add(Me.btSalvarNomeSala)
        Me.Controls.Add(Me.btDesfazer)
        Me.Name = "cadSalaNome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Nomes -Salas"
        CType(Me.DadosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalasBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SalasBindingNavigator.ResumeLayout(False)
        Me.SalasBindingNavigator.PerformLayout()
        CType(Me.SalasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btSalvarNomeSala As System.Windows.Forms.Button
    Friend WithEvents btApagarSala As System.Windows.Forms.Button
    Friend WithEvents btNovaSala As System.Windows.Forms.Button
    Friend WithEvents CodigoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents btDesfazer As System.Windows.Forms.Button
    Friend WithEvents btEditarNomeSala As System.Windows.Forms.Button
    Friend WithEvents btSair As System.Windows.Forms.Button
    Friend WithEvents DadosDataSet As TV_Totem.DadosDataSet
    Friend WithEvents SalasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SalasTableAdapter As TV_Totem.DadosDataSetTableAdapters.SalasTableAdapter
    Friend WithEvents TableAdapterManager As TV_Totem.DadosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SalasBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SalasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents NomeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
