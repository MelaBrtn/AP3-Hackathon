using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BC = BCrypt.Net.BCrypt;

namespace AP3_GestionHackathon
{
    public static class Modele
    {
        private static virtualhackathonEntities maConnexion;

        /// <summary>
        /// initialise la connexion à la BD
        /// </summary>
        public static void init()
        {
            maConnexion = new virtualhackathonEntities();
        }

        ///<summary>
        ///Retourne la liste des inscrits
        /// </summary>
        /// <returns></returns>

        public static List<INSCRIRE> listeInscrire()
        {
            return maConnexion.INSCRIRE.ToList();
        }

        ///<summary>
        ///Retourne toute la liste des équipes
        /// </summary>
        /// <returns></returns>

        public static List<EQUIPE> listeEquipes()
        {
            return maConnexion.EQUIPE.ToList();
        }

        ///<summary>
        ///Retourne toute la liste des membres
        /// </summary>
        /// <returns></returns>

        public static List<MEMBRE> listeMembres()
        {
            return maConnexion.MEMBRE.ToList();
        }

        ///<summary>
        ///Retourne toute la liste des entreprises
        /// </summary>
        /// <returns></returns>

        public static List<ENTREPRISE> listeEntreprises()
        {
            return maConnexion.ENTREPRISE.ToList();
        }

        internal static void DesinscrireEquipe()
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Retourne toute la liste des hackathons
        /// </summary>
        /// <returns></returns>
        public static List<HACKATHON> listeHackathons()
        {
            return maConnexion.HACKATHON.ToList();
        }

        ///<summary>
        ///Retourne liste administrateur
        /// </summary>
        /// <returns></returns>
        public static List<ADMINISTRATEUR> listeAdministrateur()
        {
            return maConnexion.ADMINISTRATEUR.ToList();
        }

        /// <summary>
        /// Retourne toute la liste des organisateurs
        /// </summary>
        /// <returns></returns>
        public static List<ORGANISATEUR> listeOrganisateurs()
        {
            return maConnexion.ORGANISATEUR.ToList();
        }

        /// <summary>
        /// Retourne la liste des équipes inscrites à l'hackathon dont l'identifiant est passé en paramètre
        /// </summary>
        /// <param name="idH"></param>
        /// <returns></returns>
        public static List<EQUIPE> listeEquipesParHackathon(int idH)
        {
            // parcourir les équipes et récupérer celle de l'hackathon
            HACKATHON h = maConnexion.HACKATHON.Find(idH);
            List<INSCRIRE> lesI = h.INSCRIRE.ToList();
            List<EQUIPE> lesE = new List<EQUIPE>();
            foreach (INSCRIRE I in lesI)
            {
                lesE.Add(I.EQUIPE);
            }
            return lesE;
        }


        /// <summary>
        /// Retourne l'identifiant du dernier hackathon saisi dans la BD
        /// </summary>
        /// <returns></returns>
        public static int RetourneDernierHackathonSaisi()
        {
            return maConnexion.HACKATHON.Max(x => x.idhackathon);
        }

        /// <summary>
        /// Retourne l'identifiant du derniere équipe saisi dans la BD
        /// </summary>
        /// <returns></returns>
        public static int RetourneDerniereEquipeSaisie()
        {
            return maConnexion.EQUIPE.Max(x => x.idequipe);
        }

        ///<summary>
        ///Retourne vrai si l'ajout d'une équipe a pu avoir lieu en BD
        /// Faux sinon
        /// </summary>
        /// <param name="nomequipe"></param>
        /// <param name="login"></param>
        /// <param name="lienprototype"></param>
        /// <param name="password"></param>
        /// <param name="nbparticipants"></param>
        /// <returns></returns>

        public static bool AjoutEquipe(string nomequipe, string login, string lienprototype, string password, int nbparticipants)
        {
            EQUIPE uneEquipe;
            bool vretour = true;
            try
            {
                // ajout dans la table commande
                uneEquipe = new EQUIPE();
                uneEquipe.nomequipe = nomequipe;
                uneEquipe.login = login;
                uneEquipe.lienprototype = lienprototype;
                uneEquipe.password = password;
                uneEquipe.nbparticipants = nbparticipants;

                maConnexion.EQUIPE.Add(uneEquipe);
                maConnexion.SaveChanges();

            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
        }

        /// <summary>
        /// Fonction qui retourne l'objet equipe qui correspond à l'identifiant passé en paramètre 
        /// </summary>
        /// <param name="idE">identifiant de l'équipe</param>
        /// <returns></returns>
        public static EQUIPE RecupererEquipe(int idE)
        {
            EQUIPE uneEquipe = new EQUIPE();
            try
            {
                uneEquipe = maConnexion.EQUIPE.First(x => x.idequipe == idE);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return uneEquipe;
        }

        public static bool ModificationEquipe(int idE, string nomequipe, string login, string lienprototype, string password, int nbparticipants)
        {
            EQUIPE uneEquipe;
            bool vretour = true;
            try
            {
                // récupération de l'hackathon à modifier
                uneEquipe = RecupererEquipe(idE);

                // mise à jour des champs de l'hackathon
                uneEquipe.nomequipe = nomequipe;
                uneEquipe.login = login;
                uneEquipe.lienprototype = lienprototype;
                uneEquipe.password = password;
                uneEquipe.nbparticipants = nbparticipants;


                maConnexion.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
        }

        public static bool SupressionEquipe(int idE, string nomequipe, string login, string lienprototype, string password, int nbparticipants)
        {
            EQUIPE uneEquipe;
            bool vretour = true;
            try
            {
                // récupération de l'hackathon à modifier
                uneEquipe = RecupererEquipe(idE);

                // suppression 
                uneEquipe.nomequipe = nomequipe;
                uneEquipe.login = login;
                uneEquipe.lienprototype = lienprototype;
                uneEquipe.password = password;
                uneEquipe.nbparticipants = nbparticipants;

                maConnexion.EQUIPE.Remove(uneEquipe);
                maConnexion.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
        }

        ///<summary>
        ///Retourne vrai si la désinscription a pu avoi lieu en BD
        ///Faux sinon
        /// </summary>
        /// <param name="idE"></param>
        /// <param name="datedesinscription"></param>
        /// <returns></returns>

        public static bool DesinscrireEquipe(int idE, DateTime datedesinscription)
        {
            INSCRIRE uneEquipe;
            bool vretour = true;
            try
            {
                // ajout dans la table commande
                uneEquipe = new INSCRIRE();
                uneEquipe.datedésincription = datedesinscription;

                maConnexion.INSCRIRE.Add(uneEquipe);
                maConnexion.SaveChanges();

            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
        }

        /// <summary>
        /// Retourne l'identifiant du dernier membres saisi dans la BD
        /// </summary>
        /// <returns></returns>
        public static int RetourneDernierMembreSaisi()
        {
            return maConnexion.MEMBRE.Max(x => x.idmembre);
        }


        /// <summary>
        /// Retourne vrai si l'ajout d'un hackathon a pu avoir lieu en BD
        /// Faux sinon
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="telephone"></param>
        /// <param name="datenaissance"></param>
        /// <param name="lienportfolio"></param>
        /// <param name="idequipe"></param>
        /// <param name="identreprise"></param>
        /// <returns></returns>
        public static bool AjoutMembre(string nom, string prenom, string telephone, DateTime datenaissance, string lienportfolio, int idequipe, int identreprise)
        {
            MEMBRE unMembre;
            bool vretour = true;
            try
            {
                // ajout dans la table commande
                unMembre = new MEMBRE();
                unMembre.nom = nom;
                unMembre.prenom = prenom;
                unMembre.telephone = telephone;
                unMembre.datenaissance = datenaissance;
                unMembre.lienportfolio = lienportfolio;
                unMembre.idequipe = idequipe;
                unMembre.identreprise = identreprise;


                maConnexion.MEMBRE.Add(unMembre);
                maConnexion.SaveChanges();
                               
            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
        }

        /// <summary>
        /// Fonction qui retourne l'objet membre qui correspond à l'identifiant passé en paramètre 
        /// </summary>
        /// <param name="idM">identifiant de membre</param>
        /// <returns></returns>
        public static MEMBRE RecupererMembre(int idM)
        {
            MEMBRE unMembre = new MEMBRE();
            try
            {
                unMembre = maConnexion.MEMBRE.First(x => x.idmembre == idM);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return unMembre;
        }

        public static bool ModificationMembre(int idM, string nom, string prenom, string telephone, DateTime datenaissance, string lienportfolio, int idequipe, int identreprise)
        {
            MEMBRE unMembre;
            bool vretour = true;
            try
            {
                // récupération de le membre à modifier
                unMembre = RecupererMembre(idM);

                // mise à jour des champs du membre
                unMembre.nom = nom;
                unMembre.prenom = prenom;
                unMembre.telephone = telephone;
                unMembre.datenaissance = datenaissance;
                unMembre.lienportfolio = lienportfolio;
                unMembre.idequipe = idequipe;
                unMembre.identreprise = identreprise;

                maConnexion.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
        }

        public static bool SupressionMembre(int idM, string nom, string prenom, string telephone, DateTime datenaissance, string lienportfolio, int idequipe, int identreprise)
        {
            MEMBRE unMembre;
            bool vretour = true;
            try
            {
                // récupération de le membre à supprimer
                unMembre = RecupererMembre(idM);

                // suppression 
                unMembre.nom = nom;
                unMembre.prenom = prenom;
                unMembre.telephone = telephone;
                unMembre.datenaissance = datenaissance;
                unMembre.lienportfolio = lienportfolio;
                unMembre.idequipe = idequipe;
                unMembre.identreprise = identreprise;

                maConnexion.MEMBRE.Remove(unMembre);
                maConnexion.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
        }

        /// <summary>
        /// Fonction qui retourne l'objet hackathon qui correspond à l'identifiant passé en paramètre 
        /// </summary>
        /// <param name="idH">identifiant de l'hackathon</param>
        /// <returns></returns>
        public static HACKATHON RecupererHackathon(int idH)
        {
            HACKATHON unHackathon = new HACKATHON();
            try
            {
                unHackathon = maConnexion.HACKATHON.First(x => x.idhackathon == idH);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return unHackathon;
        }
        /// <summary>
        /// Retourne vrai si l'ajout d'un hackathon a pu avoir lieu en BD
        /// Faux sinon
        /// </summary>
        /// <param name="lieu"></param>
        /// <param name="ville"></param>
        /// <param name="thematique"></param>
        /// <param name="objectifs"></param>
        /// <param name="conditions"></param>
        /// <param name="affiche"></param>
        /// <param name="dateD"></param>
        /// <param name="dateF"></param>
        /// <param name="idOrganisateur"></param>
        /// <param name="nbPlaceMax"></param>
        /// <param name="dateButoirInscrip"></param>
        /// 
        /// <returns></returns>
        public static bool AjoutHackathon(string lieu, string ville, string thematique, string objectifs, string conditions, string affiche, DateTime dateD, DateTime dateF, int idOrganisateur, int nbPlaceMax, DateTime dateButoirInscrip)
        {
            HACKATHON unHackathon;
            bool vretour = true;
            try
            {
                // ajout dans la table commande
                unHackathon = new HACKATHON();
                unHackathon.lieu = lieu;
                unHackathon.ville = ville;
                unHackathon.thematique = thematique;
                unHackathon.conditions = conditions;
                unHackathon.objectifs = objectifs;
                unHackathon.affiche = affiche;
                unHackathon.dateheuredebuth = dateD;
                unHackathon.dateheurefinh = dateF;
                unHackathon.idorganisateur = idOrganisateur;
                unHackathon.nbPlaceMax = nbPlaceMax;
                unHackathon.DateButoirInscrip = dateButoirInscrip;


                maConnexion.HACKATHON.Add(unHackathon);
                maConnexion.SaveChanges();

            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
        }

        public static bool ModificationHackathon(int idH, string lieu, string ville, string thematique, string objectifs, string conditions, string affiche, DateTime dateD, DateTime dateF, int idOrganisateur, int nbPlaceMax, DateTime dateButoirInscrip)
        {
            HACKATHON unHackathon;
            bool vretour = true;
            try
            {
                // récupération de l'hackathon à modifier
                unHackathon = RecupererHackathon(idH);

                // mise à jour des champs de l'hackathon
                unHackathon.lieu = lieu;
                unHackathon.ville = ville;
                unHackathon.thematique = thematique;
                unHackathon.conditions = conditions;
                unHackathon.objectifs = objectifs;
                unHackathon.affiche = affiche;
                unHackathon.dateheuredebuth = dateD;
                unHackathon.dateheurefinh = dateF;
                unHackathon.idorganisateur = idOrganisateur;
                unHackathon.nbPlaceMax = nbPlaceMax;
                unHackathon.DateButoirInscrip = dateButoirInscrip;

                maConnexion.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
        }
        
        public static bool SupressionHackathon(int idH, string lieu, string ville, string thematique, string objectifs, string conditions, string affiche, DateTime dateD, DateTime dateF, int idOrganisateur, int nbPlaceMax, DateTime dateButoirInscrip)
        {
            HACKATHON unHackathon;
            bool vretour = true;
            try
            {
                // récupération de l'hackathon à modifier
                unHackathon = RecupererHackathon(idH);

                // suppression 
                unHackathon.lieu = lieu;
                unHackathon.ville = ville;
                unHackathon.thematique = thematique;
                unHackathon.conditions = conditions;
                unHackathon.objectifs = objectifs;
                unHackathon.affiche = affiche;
                unHackathon.dateheuredebuth = dateD;
                unHackathon.dateheurefinh = dateF;
                unHackathon.idorganisateur = idOrganisateur;
                unHackathon.nbPlaceMax = nbPlaceMax;
                unHackathon.DateButoirInscrip = dateButoirInscrip;

                maConnexion.HACKATHON.Remove(unHackathon);
                maConnexion.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
        }

        /// <summary>
        /// Retourne vrai si l'ajout d'un organisateur a pu avoir lieu
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="email"></param>
        /// <returns></returns>
        public static bool AjoutOrganisateur(string nom, string prenom, string email)
        {
            ORGANISATEUR unOrga;
            bool vretour = true;
            try
            {
                // ajout dans la table commande
                unOrga = new ORGANISATEUR();
                unOrga.nom = nom;
                unOrga.prenom = prenom;
                unOrga.email = email;

                maConnexion.ORGANISATEUR.Add(unOrga);
                maConnexion.SaveChanges();

            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
        }

        /// <summary>
        /// Recupére l'id (email) de la table ADMINISTRATEUR 
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool Authentification(string email, string password)
        {
            bool connretour = false;
            ADMINISTRATEUR unAdministrateur = new ADMINISTRATEUR();
            try
            {
                connretour = true;
                unAdministrateur = maConnexion.ADMINISTRATEUR.First(x => x.email == email);
                string passwordHash = unAdministrateur.motpasse;
                bool verified = BCrypt.Net.BCrypt.Verify(password, passwordHash);

                if(verified)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                connretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return connretour;
        }


    }
}
