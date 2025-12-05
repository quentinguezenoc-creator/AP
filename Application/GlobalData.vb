Imports System.Data.Odbc

Module GlobalData

    ' Chaîne de connexion commune (mot de passe Iroise29, hôte gestion)
    Public ReadOnly ConnexionString As String = "DSN=SRVORAGSB;Uid=gestion;Pwd=Iroise29;"

    ' Matricule de l'utilisateur connecté (Visiteur, Délégué, ou Responsable)
    Public MatriculeUtilisateurConnecte As String = String.Empty

    ' Rôle de l'utilisateur connecté (pour déterminer les droits et la navigation)
    Public RoleUtilisateurConnecte As String = String.Empty

End Module