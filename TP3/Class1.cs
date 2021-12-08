namespace TP3
{
    public class Class1
    {
        public static void tri_a_bulle(ref int[] t, int n)
        {
            int tmp = 0; // Variable de stockage temporaire
                         // Booléen marquant l'arrêt du tri si le tableau est ordonné
            bool en_desordre = true;
            /* Boucle de répétition du tri et le test qui
           arrête le tri dès que le tableau est ordonné (en_desordre=false) */
            while (en_desordre)
            {
                // Supposons le tableau ordonné
                en_desordre = false;
                for (int j = 0; j < n - 1; j++)
                {
                    // Si les 2 éléments sont mal triés
                    if (t[j] > t[j + 1])
                    {
                        /* Inversion des 2 éléments */
                        tmp = t[j + 1];
                        t[j + 1] = t[j];
                        t[j] = tmp;
                        // Le tableau n'est toujours pas trié
                        en_desordre = true;
                    }
                }
            }
        }
    }
}