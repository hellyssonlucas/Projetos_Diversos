<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cadEventoNome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cadEventoNome))
        Me.btNovoEvento = New System.Windows.Forms.Button()
        Me.btApagarNomeEvento = New System.Windows.Forms.Button()
        Me.btSalvarNomeEvento = New System.Windows.Forms.Button()
        Me.btEditarNomeEvento = New System.Windows.Forms.Button()
        Me.btDesfazer = New System.Windows.Forms.Button()
        Me.btSair = New System.Windows.Forms.Button()
        Me.EventosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.EventosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DadosDataSet = New TV_Totem.DadosDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.EventosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EventosTableAdapter = New TV_Totem.DadosDataSetTableAdapters.EventosTableAdapter()
        Me.TableAdapterManager = New TV_Totem.DadosDataSetTableAdapters.TableAdapterManager()
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        NomeLabel = New System.Windows.Forms.Label()
        CType(Me.EventosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EventosBindingNavigator.SuspendLayout()
        CType(Me.EventosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DadosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EventosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Location = New System.Drawing.Point(13, 44)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(75, 13)
        NomeLabel.TabIndex = 10
        NomeLabel.Text = "Nome Evento:"
        '
        'btNovoEvento
        '
        Me.btNovoEvento.Location = New System.Drawing.Point(14, 325)
        Me.btNovoEvento.Name = "btNovoEvento"
        Me.btNovoEvento.Size = New System.Drawing.Size(61, 50)
        Me.btNovoEvento.TabIndex = 9
        Me.btNovoEvento.Text = "Novo"
        Me.btNovoEvento.UseVisualStyleBackColor = True
        '
        'btApagarNomeEvento
        '
        Me.btApagarNomeEvento.Location = New System.Drawing.Point(213, 325)
        Me.btApagarNomeEvento.Name = "btApagarNomeEvento"
        Me.btApagarNomeEvento.Size = New System.Drawing.Size(61, 50)
        Me.btApagarNomeEvento.TabIndex = 8
        Me.btApagarNomeEvento.Text = "Apagar"
        Me.btApagarNomeEvento.UseVisualStyleBackColor = True
        '
        'btSalvarNomeEvento
        '
        Me.btSalvarNomeEvento.Location = New System.Drawing.Point(146, 325)
        Me.btSalvarNomeEvento.Name = "btSalvarNomeEvento"
        Me.btSalvarNomeEvento.Size = New System.Drawing.Size(61, 50)
        Me.btSalvarNomeEvento.TabIndex = 7
        Me.btSalvarNomeEvento.Text = "Salvar"
        Me.btSalvarNomeEvento.UseVisualStyleBackColor = True
        '
        'btEditarNomeEvento
        '
        Me.btEditarNomeEvento.Location = New System.Drawing.Point(79, 325)
        Me.btEditarNomeEvento.Name = "btEditarNomeEvento"
        Me.btEditarNomeEvento.Size = New System.Drawing.Size(61, 50)
        Me.btEditarNomeEvento.TabIndex = 12
        Me.btEditarNomeEvento.Text = "Editar"
        Me.btEditarNomeEvento.UseVisualStyleBackColor = True
        '
        'btDesfazer
        '
        Me.btDesfazer.Location = New System.Drawing.Point(79, 325)
        Me.btDesfazer.Name = "btDesfazer"
        Me.btDesfazer.Size = New System.Drawing.Size(61, 50)
        Me.btDesfazer.TabIndex = 13
        Me.btDesfazer.Text = "Desfazer"
        Me.btDesfazer.UseVisualStyleBackColor = True
        '
        'btSair
        '
        Me.btSair.Location = New System.Drawing.Point(324, 325)
        Me.btSair.Name = "btSair"
        Me.btSair.Size = New System.Drawing.Size(61, 50)
        Me.btSair.TabIndex = 17
        Me.btSair.Text = "Sair"
        Me.btSair.UseVisualStyleBackColor = True
        '
        'EventosBindingNavigator
        '
        Me.EventosBindingNavigator.AddNewItem = Nothing
        Me.EventosBindingNavigator.BindingSource = Me.EventosBindingSource
        Me.EventosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EventosBindingNavigator.DeleteItem = Nothing
        Me.EventosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.EventosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EventosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EventosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EventosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EventosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EventosBindingNavigator.Name = "EventosBindingNavigator"
        Me.EventosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EventosBindingNavigator.Size = New System.Drawing.Size(418, 25)
        Me.EventosBindingNavigator.TabIndex = 18
        Me.EventosBindingNavigator.Text = "EventosBindingNavigator"
        '
        'EventosBindingSource
        '
        Me.EventosBindingSource.DataMember = "Eventos"
        Me.EventosBindingSource.DataSource = Me.DadosDataSet
        '
        'DadosDataSet
        '
        Me.DadosDataSet.DataSetName = "DadosDataSet"
        Me.DadosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'EventosDataGridView
        '
        Me.EventosDataGridView.AutoGenerateColumns = False
        Me.EventosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EventosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2})
        Me.EventosDataGridView.DataSource = Me.EventosBindingSource
        Me.EventosDataGridView.Location = New System.Drawing.Point(14, 83)
        Me.EventosDataGridView.Name = "EventosDataGridView"
        Me.EventosDataGridView.Size = New System.Drawing.Size(371, 220)
        Me.EventosDataGridView.TabIndex = 18
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nome"
        Me.DataGridViewTextBoxColumn2.HeaderText = "nome"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 327
        '
        'EventosTableAdapter
        '
        Me.EventosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EventosTableAdapter = Me.EventosTableAdapter
        Me.TableAdapterManager.SalasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = TV_Totem.DadosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'NomeTextBox
        '
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EventosBindingSource, "nome", True))
        Me.NomeTextBox.Location = New System.Drawing.Point(94, 41)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(291, 20)
        Me.NomeTextBox.TabIndex = 19
        '
        'cadEventoNome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 401)
        Me.Controls.Add(Me.NomeTextBox)
        Me.Controls.Add(Me.EventosDataGridView)
        Me.Controls.Add(Me.EventosBindingNavigator)
        Me.Controls.Add(Me.btSair)
        Me.Controls.Add(Me.btEditarNomeEvento)
        Me.Controls.Add(NomeLabel)
        Me.Controls.Add(Me.btNovoEvento)
        Me.Controls.Add(Me.btApagarNomeEvento)
        Me.Controls.Add(Me.btSalvarNomeEvento)
        Me.Controls.Add(Me.btDesfazer)
        Me.Name = "cadEventoNome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Nomes - Eventos"
        CType(Me.EventosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EventosBindingNavigator.ResumeLayout(False)
        Me.EventosBindingNavigator.PerformLayout()
        CType(Me.EventosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DadosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EventosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btNovoEvento As System.Windows.Forms.Button
    Friend WithEvents btApagarNomeEvento As System.Windows.Forms.Button
    Friend WithEvents btSalvarNomeEvento As System.Windows.Forms.Button
    Friend WithEvents btEditarNomeEvento As System.Windows.Forms.Button
    Friend WithEvents btDesfazer As System.Windows.Forms.Button
    Friend WithEvents btSair As System.Windows.Forms.Button
    Friend WithEvents DadosDataSet As TV_Totem.DadosDataSet
    Friend WithEvents EventosBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EventosTableAdapter As TV_Totem.DadosDataSetTableAdapters.EventosTableAdapter
    Friend WithEvents EventosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterManager As TV_Totem.DadosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EventosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents NomeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
