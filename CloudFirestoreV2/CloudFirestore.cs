using Google.Cloud.Firestore;

namespace CloudFirestoreV2
{
    public class CloudFirestore
    {
        public async Task BuscarDados()
        {
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", "service-account-cloudfirestore.json");
            Console.WriteLine($"CRIAÇÃO CONCLUÍIDA DA VARIÁVEL DE AMBIENTE.");

            FirestoreDb firestoreDb = FirestoreDb.Create("nome_projeto");
            CollectionReference documentosRef = firestoreDb.Collection("nome_colecao");
            Query query = documentosRef.WhereEqualTo("Cpf", "00000000000");
            QuerySnapshot querySnapshot = await query.GetSnapshotAsync();

            foreach (DocumentSnapshot documentSnapshot in querySnapshot.Documents)
            {
                Dictionary<string, object> documento = documentSnapshot.ToDictionary();

                foreach (KeyValuePair<string, object> parametro in documento)
                {
                    Console.WriteLine("{0}: {1}", parametro.Key, parametro.Value);
                }

                Console.WriteLine("");
            }
        }
    }
}
