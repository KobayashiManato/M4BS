Module Utils
    Private Const FMT_CURRENCY As String = "#,##0"

    ' オブジェクトを安全にIntegerに変換する
    Public Function NzInt(value As Object, Optional defaultValue As Object = 0) As Object
        If value Is Nothing OrElse IsDBNull(value) OrElse String.IsNullOrEmpty(value.ToString()) Then
            Return defaultValue
        End If

        Dim result As Integer
        If Integer.TryParse(value.ToString(), result) Then
            Return result
        Else
            Return defaultValue
        End If
    End Function

    Public Function NzDate(value As Object) As DateTime
        If value Is Nothing OrElse IsDBNull(value) Then
            Return DateTime.Today
        End If

        Dim result As DateTime
        If DateTime.TryParse(value?.ToString(), result) Then
            Return result
        Else
            Return DateTime.Today
        End If
    End Function

    Public Function NzDec(value As Object) As Decimal
        If value Is Nothing OrElse IsDBNull(value) OrElse String.IsNullOrEmpty(value.ToString()) Then
            Return 0D
        End If

        Dim result As Decimal
        If Decimal.TryParse(value.ToString().Replace(",", ""), Globalization.NumberStyles.Any, Nothing, result) Then
            Return result
        Else
            Return 0D
        End If
    End Function

    Public Function ToCurrency(value As Object) As String
        Return NzDec(value).ToString(FMT_CURRENCY)
    End Function
End Module
