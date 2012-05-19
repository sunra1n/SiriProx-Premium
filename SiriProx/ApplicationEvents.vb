Namespace My

    ' Für MyApplication sind folgende Ereignisse verfügbar:
    ' 
    ' Startup: Wird beim Starten der Anwendung noch vor dem Erstellen des Startformulars ausgelöst.
    ' Shutdown: Wird nach dem Schließen aller Anwendungsformulare ausgelöst. Dieses Ereignis wird nicht ausgelöst, wenn die Anwendung nicht normal beendet wird.
    ' UnhandledException: Wird ausgelöst, wenn in der Anwendung eine unbehandelte Ausnahme auftritt.
    ' StartupNextInstance: Wird beim Starten einer Einzelinstanzanwendung ausgelöst, wenn diese bereits aktiv ist. 
    ' NetworkAvailabilityChanged: Wird beim Herstellen oder Trennen der Netzwerkverbindung ausgelöst.
    Partial Friend Class MyApplication
        Private WithEvents Domaene As AppDomain = AppDomain.CurrentDomain
        Private Function Domaene_AssemblyResolve(ByVal sender As Object, ByVal args As System.ResolveEventArgs) As System.Reflection.Assembly Handles Domaene.AssemblyResolve
            If args.Name.Contains("MobileDevice") Then
                Return System.Reflection.Assembly.Load(My.Resources.MobileDevice)
            Else
                Return Nothing
            End If
            If args.Name.Contains("DeffieHellman") Then
                Return System.Reflection.Assembly.Load(My.Resources.DiffieHellman)
            Else
                Return Nothing
            End If
            If args.Name.Contains("Ionic.Zip") Then
                Return System.Reflection.Assembly.Load(My.Resources.Ionic_Zip)
            Else
                Return Nothing
            End If
            If args.Name.Contains("MySql.Data") Then
                Return System.Reflection.Assembly.Load(My.Resources.MySql_Data)
            Else
                Return Nothing
            End If
            If args.Name.Contains("Org.Mentalis.Security") Then
                Return System.Reflection.Assembly.Load(My.Resources.Org_Mentalis_Security)
            Else
                Return Nothing
            End If
            If args.Name.Contains("Tamir.SharpSSH") Then
                Return System.Reflection.Assembly.Load(My.Resources.Tamir_SharpSSH)
            Else
                Return Nothing
            End If
         End Function
    End Class
End Namespace

