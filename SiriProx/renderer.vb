Public Class Renderer
    Inherits ToolStripProfessionalRenderer
    Protected Overrides Sub OnRenderToolStripBorder(ByVal e As System.Windows.Forms.ToolStripRenderEventArgs)

    End Sub

    Protected Overrides Sub OnRenderButtonBackground(ByVal e As System.Windows.Forms.ToolStripItemRenderEventArgs)

    End Sub
    Protected Overrides Sub OnRenderSeparator(ByVal e As System.Windows.Forms.ToolStripSeparatorRenderEventArgs)
        Dim BMP As New Bitmap(1, 32)
        Dim G As Graphics = Graphics.FromImage(BMP)
        e.Item.AutoSize = False
        e.Item.Height = 48
        e.Item.Width = 7
        For i = 0 To e.Item.Height Step 3
            e.Graphics.DrawImage(My.Resources.seperator, 3, i)
        Next
    End Sub


End Class
