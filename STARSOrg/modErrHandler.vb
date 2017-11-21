Module modErrHandler
    ' useful routines for input validation
    Public Function ValidateTextBoxLength(ByRef obj As TextBox, ByRef errP As ErrorProvider) As Boolean
        'this procedure validates that a textbox is not empty
        If obj.Text.Length = 0 Then
            errP.SetIconAlignment(obj, ErrorIconAlignment.MiddleLeft)
            errP.SetError(obj, "You must enter a value here")
            obj.Focus()
            Return False
        Else
            errP.SetError(obj, "")
            Return True
        End If
    End Function
    Public Function ValidateTextBoxNumber(ByRef obj As TextBox, ByRef errP As ErrorProvider) As Boolean
        'This procedure validates that a textbox has a numeric value. Works for empty textboxes as well
        If Not IsNumeric(obj.Text) Then
            errP.SetIconAlignment(obj, ErrorIconAlignment.MiddleLeft)
            errP.SetError(obj, "You must enter a numeric value here")
            Return False
        Else
            errP.SetError(obj, "")
            Return True
        End If
    End Function

    Public Function ValidateTextBoxDate(ByRef obj As TextBox, ByRef errP As ErrorProvider) As Boolean
        If Not IsDate(obj.Text) Then
            errP.SetIconAlignment(obj, ErrorIconAlignment.MiddleLeft)
            errP.SetError(obj, "You must enter a valid date here")
            Return False
        Else
            errP.SetError(obj, "")
            Return True
        End If
    End Function
    Public Function ValidateCombo(ByRef obj As ComboBox, ByRef errP As ErrorProvider) As Boolean
        'Validate that comvovox has a selection
        If obj.SelectedIndex = -1 Then
            errP.SetIconAlignment(obj, ErrorIconAlignment.MiddleLeft)
            errP.SetError(obj, "You must make a selection here")
            Return False
        Else
            errP.SetError(obj, "")
            Return True
        End If
    End Function
    Public Function ValidateMaskTextBoxLength(ByRef obj As MaskedTextBox, ByRef errP As ErrorProvider) As Boolean
        'Validate that masked text box has a selection
        If obj.Text.Length = 0 Then
            errP.SetIconAlignment(obj, ErrorIconAlignment.MiddleLeft)
            errP.SetError(obj, "You must make a selection here")
            Return False
        Else
            errP.SetError(obj, "")
            Return True
        End If

    End Function
    Public Function ValidateMaskedTextBoxDate(ByRef obj As MaskedTextBox, ByRef errP As ErrorProvider) As Boolean
        'Validate that masked text box has a selection
        If obj.Text.Length = 0 Then
            errP.SetIconAlignment(obj, ErrorIconAlignment.MiddleLeft)
            errP.SetError(obj, "You must make a selection here")
            Return False
        Else
            errP.SetError(obj, "")
            Return True
        End If
    End Function
End Module