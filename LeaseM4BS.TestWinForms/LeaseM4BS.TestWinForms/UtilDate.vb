Public Module UtilDate
    ' 集計期間の計算(ヶ月)
    Public Function GetDuration(dtFrom As Date, dtTo As Date) As Integer
        If dtFrom > dtTo Then
            Return 0
        End If

        Return DateDiff(DateInterval.Month, dtFrom, dtTo) + 1
    End Function

    ' 月初(yyyy/MM/01を求める)
    Public Function GetMonthStart(val As Object) As Date
        If val Is Nothing OrElse IsDBNull(val) Then
            Return Date.MinValue
        End If

        Dim dt As Date
        If Date.TryParse(val.ToString(), dt) Then
            Return New Date(dt.Year, dt.Month, 1)
        End If

        Return Date.MinValue
    End Function

    ' 月末(yyyy/MM/31を求める)
    Public Function GetMonthEnd(val As Object) As Date
        If val Is Nothing OrElse IsDBNull(val) Then
            Return Date.MinValue
        End If

        Dim dt As Date
        If Date.TryParse(val.ToString(), dt) Then
            Return New Date(dt.Year, dt.Month, 1).AddMonths(1).AddDays(-1)
        End If

        Return Date.MinValue
    End Function

    Public Function ToDateStr(val As Object, Optional fmt As String = "yyyy/MM/dd") As String
        If val Is Nothing OrElse IsDBNull(val) Then
            Return ""
        End If

        Dim dt As Date
        If Date.TryParse(val.ToString(), dt) Then
            Return dt.ToString(fmt)
        End If

        Return ""
    End Function
End Module