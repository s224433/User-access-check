### Til at starte med har jeg brugt Console.Write og Console.ReadLine, så rider kan stille spørgsmål til brugeren om username, og password og userId.
### Jeg har efterfølgende lavet tre tjek udfra opgavebeskrivelsen
#### Om brugeren er admin (userId > 65536).
#### Om brugernavnet har mindst 3 tegn.
#### Om password indeholder mindst ét af tegnene $, | eller @, og om længden er mindst 20 for admin og 16 for ikke-admin.

### Til slut har jeg  en if/else. Hvis  brugernavn og password er gyldige fortæller rider os at “Login successful”, og hvis ikke, får vi at vide at “Login failed”
### Jeg har testst scenarie som er: username = testuser, password = abcdefghij12345678910@, userId = 80000
### Det har givet mig resultatet; User is Admin = true, Username is valid = true, Password is valid = true, login successful.
