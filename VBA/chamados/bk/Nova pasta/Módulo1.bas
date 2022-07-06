Attribute VB_Name = "Módulo1"
Declare PtrSafe Function FindWindowA& Lib "user32" (ByVal lpClassName$, ByVal lpWindowName$)
Declare PtrSafe Function GetWindowLongA& Lib "user32" (ByVal hwnd&, ByVal nIndex&)
Declare PtrSafe Function SetWindowLongA& Lib "user32" (ByVal hwnd&, ByVal nIndex&, ByVal dwNewLong&)
Public Const GWL_STYLE As Long = -16
Public Const WS_MINIMIZEBOX = &H20000
Public Const WS_MAXIMIZEBOX = &H10000
Public Const WS_FULLSIZING = &H70000
Public Sub InitMaxMin(mCaption As String, Optional Max As Boolean = False, Optional Min As Boolean = True _
        , Optional Sizing As Boolean = False)
Dim hwnd As Long
    hwnd = FindWindowA(vbNullString, mCaption)
    If Max Then SetWindowLongA hwnd, GWL_STYLE, GetWindowLongA(hwnd, GWL_STYLE) Or WS_MAXIMIZEBOX
    If Min Then SetWindowLongA hwnd, GWL_STYLE, GetWindowLongA(hwnd, GWL_STYLE) Or WS_MINIMIZEBOX
    If Sizing Then SetWindowLongA hwnd, GWL_STYLE, GetWindowLongA(hwnd, GWL_STYLE) Or WS_FULLSIZING
End Sub

Sub OrdenarComboBox(Cb As MSForms.ComboBox)
    
    Dim Lista As Variant, Auxiliar As Variant
    Dim TotalItens As Long, Y As Long, X As Long
    
    With Cb
    
        Lista = .List
        TotalItens = .ListCount - 1
        
        For Y = 0 To TotalItens
        
            For X = Y To TotalItens
                    
                If Lista(Y, 0) > Lista(X, 0) Then
                    Auxiliar = Lista(Y, 0)
                    Lista(Y, 0) = Lista(X, 0)
                    Lista(X, 0) = Auxiliar
                End If
                    
            Next
            
        Next
        
        .RowSource = Empty
        
        .List = Lista
    
    End With
    
End Sub

