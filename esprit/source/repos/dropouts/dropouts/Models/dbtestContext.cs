using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace dropouts.Models
{
    public partial class dbtestContext : DbContext
    {
        public dbtestContext()
        {
        }

        public dbtestContext(DbContextOptions<dbtestContext> options)
            : base(options)
        {
        }

        public virtual DbSet<EspInscription> EspInscriptions { get; set; } = null!;
        public virtual DbSet<EtudiantsInscritArchiv> EtudiantsInscritArchivs { get; set; } = null!;
        public virtual DbSet<InscriArchiv> InscriArchivs { get; set; } = null!;
        public virtual DbSet<Societe> Societes { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Host=localhost;Database=dbtest;Username=postgres;Password=dbtest");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EspInscription>(entity =>
            {
                entity.HasKey(e => new { e.AnneeDeb, e.IdEt });

                entity.ToTable("ESP_INSCRIPTION", "dbtest");

                entity.Property(e => e.AnneeDeb)
                    .HasColumnType("character varying")
                    .HasColumnName("ANNEE_DEB");

                entity.Property(e => e.IdEt)
                    .HasColumnType("character varying")
                    .HasColumnName("ID_ET");

                entity.Property(e => e.AdmisRach)
                    .HasColumnType("character varying")
                    .HasColumnName("ADMIS_RACH");

                entity.Property(e => e.AdmisTs)
                    .HasColumnType("character varying")
                    .HasColumnName("ADMIS_TS")
                    .HasDefaultValueSql("'N'::character varying");

                entity.Property(e => e.AnneeFin)
                    .HasColumnType("character varying")
                    .HasColumnName("ANNEE_FIN");

                entity.Property(e => e.CodeCl)
                    .HasColumnType("character varying")
                    .HasColumnName("CODE_CL");

                entity.Property(e => e.CodeCl1)
                    .HasColumnType("character varying")
                    .HasColumnName("CODE_CL1");

                entity.Property(e => e.CodeCl2)
                    .HasColumnType("character varying")
                    .HasColumnName("CODE_CL2");

                entity.Property(e => e.CodeClLangue)
                    .HasColumnType("character varying")
                    .HasColumnName("CODE_CL_LANGUE");

                entity.Property(e => e.CodeDecisionSessionP)
                    .HasColumnType("character varying")
                    .HasColumnName("CODE_DECISION_SESSION_P");

                entity.Property(e => e.CodeDecisionSessionRat)
                    .HasColumnType("character varying")
                    .HasColumnName("CODE_DECISION_SESSION_RAT");

                entity.Property(e => e.CodeDecisionSessionRat2)
                    .HasColumnType("character varying")
                    .HasColumnName("CODE_DECISION_SESSION_RAT2");

                entity.Property(e => e.CodeDev)
                    .HasColumnType("character varying")
                    .HasColumnName("CODE_DEV");

                entity.Property(e => e.CoefPfe).HasColumnName("COEF_PFE");

                entity.Property(e => e.CoutAnnuel).HasColumnName("COUT_ANNUEL");

                entity.Property(e => e.CoutDev).HasColumnName("COUT_DEV");

                entity.Property(e => e.CreditAnt)
                    .HasColumnType("character varying")
                    .HasColumnName("CREDIT_ANT");

                entity.Property(e => e.CreditRglt).HasColumnName("CREDIT_RGLT");

                entity.Property(e => e.DateCreation)
                    .HasColumnType("character varying")
                    .HasColumnName("DATE_CREATION");

                entity.Property(e => e.DateInsc)
                    .HasColumnType("character varying")
                    .HasColumnName("DATE_INSC");

                entity.Property(e => e.DateLastMajDecisionPrinc).HasColumnName("DATE_LAST_MAJ_DECISION_PRINC");

                entity.Property(e => e.DateLastMajDecisionRatt).HasColumnName("DATE_LAST_MAJ_DECISION_RATT");

                entity.Property(e => e.DateLastModifRat2).HasColumnName("DATE_LAST_MODIF_RAT2");

                entity.Property(e => e.DateLimProlongRglt)
                    .HasColumnType("character varying")
                    .HasColumnName("DATE_LIM_PROLONG_RGLT");

                entity.Property(e => e.DateNe).HasColumnName("DATE_NE");

                entity.Property(e => e.DatePreinsc)
                    .HasColumnType("character varying")
                    .HasColumnName("DATE_PREINSC");

                entity.Property(e => e.DateTestAng).HasColumnName("DATE_TEST_ANG");

                entity.Property(e => e.DateTestFr).HasColumnName("DATE_TEST_FR");

                entity.Property(e => e.DernUtilisateur)
                    .HasColumnType("character varying")
                    .HasColumnName("DERN_UTILISATEUR");

                entity.Property(e => e.EncadrantPeda)
                    .HasColumnType("character varying")
                    .HasColumnName("ENCADRANT_PEDA");

                entity.Property(e => e.EtatEntretien)
                    .HasColumnType("character varying")
                    .HasColumnName("ETAT_ENTRETIEN");

                entity.Property(e => e.EtatFinancier)
                    .HasColumnName("ETAT_FINANCIER")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.EtatInsTestNiv)
                    .HasColumnType("character varying")
                    .HasColumnName("ETAT_INS_TEST_NIV")
                    .HasDefaultValueSql("'N'::character varying");

                entity.Property(e => e.ExpertPeda)
                    .HasColumnType("character varying")
                    .HasColumnName("EXPERT_PEDA");

                entity.Property(e => e.FraisIns).HasColumnName("FRAIS_INS");

                entity.Property(e => e.GroupeRglt).HasColumnName("GROUPE_RGLT");

                entity.Property(e => e.GroupeTarif)
                    .HasColumnType("character varying")
                    .HasColumnName("GROUPE_TARIF");

                entity.Property(e => e.LibDecisionSessionP)
                    .HasColumnType("character varying")
                    .HasColumnName("LIB_DECISION_SESSION_P");

                entity.Property(e => e.LibDecisionSessionRat)
                    .HasColumnType("character varying")
                    .HasColumnName("LIB_DECISION_SESSION_RAT");

                entity.Property(e => e.LibDecisionSessionRat2)
                    .HasColumnType("character varying")
                    .HasColumnName("LIB_DECISION_SESSION_RAT2");

                entity.Property(e => e.MajNiveauDefinitif)
                    .HasColumnName("MAJ_NIVEAU_DEFINITIF")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MgSeved).HasColumnName("MG_SEVED");

                entity.Property(e => e.ModeRglt)
                    .HasColumnType("character varying")
                    .HasColumnName("MODE_RGLT");

                entity.Property(e => e.MotifRglt)
                    .HasColumnType("character varying")
                    .HasColumnName("MOTIF_RGLT");

                entity.Property(e => e.MoyGenAvPfe).HasColumnName("MOY_GEN_AV_PFE");

                entity.Property(e => e.MoyGenAvPfeSp).HasColumnName("MOY_GEN_AV_PFE_SP");

                entity.Property(e => e.MoyGenAvPfeSr).HasColumnName("MOY_GEN_AV_PFE_SR");

                entity.Property(e => e.MoyGeneral).HasColumnName("MOY_GENERAL");

                entity.Property(e => e.MoyRat2).HasColumnName("MOY_RAT2");

                entity.Property(e => e.MoyRatAvRach).HasColumnName("MOY_RAT_AV_RACH");

                entity.Property(e => e.MoyRatt).HasColumnName("MOY_RATT");

                entity.Property(e => e.MoySem1).HasColumnName("MOY_SEM1");

                entity.Property(e => e.MoySem2).HasColumnName("MOY_SEM2");

                entity.Property(e => e.NbCreditModule).HasColumnName("NB_CREDIT_MODULE");

                entity.Property(e => e.NbEctsAvPfe).HasColumnName("NB_ECTS_AV_PFE");

                entity.Property(e => e.NbEctsSp).HasColumnName("NB_ECTS_SP");

                entity.Property(e => e.NbEctsSr).HasColumnName("NB_ECTS_SR");

                entity.Property(e => e.NbImpAttestReussite).HasColumnName("NB_IMP_ATTEST_REUSSITE");

                entity.Property(e => e.NbImpReleve)
                    .HasColumnName("NB_IMP_RELEVE")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Ne)
                    .HasColumnType("character varying")
                    .HasColumnName("NE");

                entity.Property(e => e.Ne2)
                    .HasColumnType("character varying")
                    .HasColumnName("NE2");

                entity.Property(e => e.NivAcquisAnglais)
                    .HasColumnType("character varying")
                    .HasColumnName("NIV_ACQUIS_ANGLAIS");

                entity.Property(e => e.NivAcquisFrancais)
                    .HasColumnType("character varying")
                    .HasColumnName("NIV_ACQUIS_FRANCAIS");

                entity.Property(e => e.NivLangue)
                    .HasColumnType("character varying")
                    .HasColumnName("NIV_LANGUE");

                entity.Property(e => e.NiveauAccees).HasColumnName("NIVEAU_ACCEES");

                entity.Property(e => e.NotePfe).HasColumnName("NOTE_PFE");

                entity.Property(e => e.NumAnnexe).HasColumnName("NUM_ANNEXE");

                entity.Property(e => e.NumAnnuelDiplome).HasColumnName("NUM_ANNUEL_DIPLOME");

                entity.Property(e => e.NumMoisInsc).HasColumnName("NUM_MOIS_INSC");

                entity.Property(e => e.NumSemaine).HasColumnName("NUM_SEMAINE");

                entity.Property(e => e.Numpromotioncs).HasColumnName("NUMPROMOTIONCS");

                entity.Property(e => e.Observation)
                    .HasColumnType("character varying")
                    .HasColumnName("OBSERVATION");

                entity.Property(e => e.PrepToeic)
                    .HasColumnType("character varying")
                    .HasColumnName("PREP_TOEIC")
                    .HasDefaultValueSql("'N'::character varying");

                entity.Property(e => e.RachatUeEt)
                    .HasColumnType("character varying")
                    .HasColumnName("RACHAT_UE_ET")
                    .HasDefaultValueSql("'N'::character varying");

                entity.Property(e => e.RangSp).HasColumnName("RANG_SP");

                entity.Property(e => e.Reserve)
                    .HasColumnType("character varying")
                    .HasColumnName("RESERVE")
                    .HasDefaultValueSql("'N'::character varying");

                entity.Property(e => e.Resultat)
                    .HasColumnType("character varying")
                    .HasColumnName("RESULTAT");

                entity.Property(e => e.Semestre).HasColumnName("SEMESTRE");

                entity.Property(e => e.SitRglt)
                    .HasColumnType("character varying")
                    .HasColumnName("SIT_RGLT");

                entity.Property(e => e.SoldeEt).HasColumnName("SOLDE_ET");

                entity.Property(e => e.TemNum).HasColumnName("TEM_NUM");

                entity.Property(e => e.TestToeic)
                    .HasColumnType("character varying")
                    .HasColumnName("TEST_TOEIC")
                    .HasDefaultValueSql("'N'::character varying");

                entity.Property(e => e.TypeInsc)
                    .HasColumnType("character varying")
                    .HasColumnName("TYPE_INSC");

                entity.Property(e => e.TypeRglt)
                    .HasColumnType("character varying")
                    .HasColumnName("TYPE_RGLT");

                entity.Property(e => e.UserLangModif)
                    .HasColumnType("character varying")
                    .HasColumnName("USER_LANG_MODIF");

                entity.Property(e => e.Utilisateur)
                    .HasColumnType("character varying")
                    .HasColumnName("UTILISATEUR");
            });

            modelBuilder.Entity<EtudiantsInscritArchiv>(entity =>
            {
                entity.HasKey(e => new { e.AnneeDeb, e.IdEt })
                    .HasName("Etudiants_inscrit_archiv_pkey");

                entity.ToTable("Etudiants_inscrit_archiv", "dbtest");

                entity.Property(e => e.AnneeDeb)
                    .HasColumnType("character varying[]")
                    .HasColumnName("annee_deb");

                entity.Property(e => e.IdEt)
                    .HasColumnType("character varying[]")
                    .HasColumnName("id_et");

                entity.Property(e => e.Cin)
                    .HasColumnType("character varying[]")
                    .HasColumnName("cin");

                entity.Property(e => e.CodeCl)
                    .HasColumnType("character varying[]")
                    .HasColumnName("code_cl");

                entity.Property(e => e.EMail)
                    .HasColumnType("character varying[]")
                    .HasColumnName("e_mail");

                entity.Property(e => e.Institution)
                    .HasColumnType("character varying[]")
                    .HasColumnName("institution");

                entity.Property(e => e.NomEt)
                    .HasColumnType("character varying[]")
                    .HasColumnName("nom_et");

                entity.Property(e => e.PnomEt)
                    .HasColumnType("character varying[]")
                    .HasColumnName("pnom_et");

                entity.Property(e => e.Tel)
                    .HasColumnType("character varying[]")
                    .HasColumnName("tel");
            });

            modelBuilder.Entity<InscriArchiv>(entity =>
            {
                entity.HasKey(e => new { e.AnneeDeb, e.IdEt })
                    .HasName("Inscri_archiv_pkey");

                entity.ToTable("Inscri_archiv", "dbtest");

                entity.Property(e => e.AnneeDeb)
                    .HasColumnType("character varying")
                    .HasColumnName("annee_deb");

                entity.Property(e => e.IdEt)
                    .HasColumnType("character varying")
                    .HasColumnName("id_et");

                entity.Property(e => e.Cin)
                    .HasColumnType("character varying")
                    .HasColumnName("cin");

                entity.Property(e => e.CodeCl)
                    .HasColumnType("character varying")
                    .HasColumnName("code_cl");

                entity.Property(e => e.EMail)
                    .HasColumnType("character varying")
                    .HasColumnName("e_mail");

                entity.Property(e => e.EMailEsp)
                    .HasColumnType("character varying")
                    .HasColumnName("e_mail_esp");

                entity.Property(e => e.Institution)
                    .HasColumnType("character varying")
                    .HasColumnName("institution");

                entity.Property(e => e.NomEt)
                    .HasColumnType("character varying")
                    .HasColumnName("nom_et");

                entity.Property(e => e.PnomEt)
                    .HasColumnType("character varying")
                    .HasColumnName("pnom_et");

                entity.Property(e => e.Tel)
                    .HasColumnType("character varying")
                    .HasColumnName("tel");
            });

            modelBuilder.Entity<Societe>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SOCIETE", "dbtest");

                entity.Property(e => e.ActiveDispenseAuto)
                    .HasColumnType("character varying")
                    .HasColumnName("ACTIVE_DISPENSE_AUTO");

                entity.Property(e => e.ActiveModuleOpt)
                    .HasColumnType("character varying")
                    .HasColumnName("ACTIVE_MODULE_OPT");

                entity.Property(e => e.ActiveMpEns)
                    .HasColumnType("character varying")
                    .HasColumnName("ACTIVE_MP_ENS");

                entity.Property(e => e.ActiverSignature)
                    .HasColumnType("character varying")
                    .HasColumnName("ACTIVER_SIGNATURE")
                    .HasDefaultValueSql("'O'::character varying");

                entity.Property(e => e.ActiverTauxAbsence)
                    .HasColumnType("character varying")
                    .HasColumnName("ACTIVER_TAUX_ABSENCE");

                entity.Property(e => e.AdrSoc)
                    .HasColumnType("character varying")
                    .HasColumnName("ADR_SOC");

                entity.Property(e => e.AffichNote)
                    .HasColumnType("character varying")
                    .HasColumnName("AFFICH_NOTE")
                    .HasDefaultValueSql("'N'::character varying");

                entity.Property(e => e.Annee)
                    .HasColumnType("character varying")
                    .HasColumnName("ANNEE");

                entity.Property(e => e.AnneeAdmission)
                    .HasColumnType("character varying")
                    .HasColumnName("ANNEE_ADMISSION");

                entity.Property(e => e.AnneeDeb)
                    .HasColumnType("character varying")
                    .HasColumnName("ANNEE_DEB");

                entity.Property(e => e.AnneeFin)
                    .HasColumnType("character varying")
                    .HasColumnName("ANNEE_FIN");

                entity.Property(e => e.Banque)
                    .HasColumnType("character varying")
                    .HasColumnName("BANQUE");

                entity.Property(e => e.BiRachat).HasColumnName("BI_RACHAT");

                entity.Property(e => e.BlockOtherRat)
                    .HasColumnType("character varying")
                    .HasColumnName("BLOCK_OTHER_RAT")
                    .HasDefaultValueSql("'N'::character varying");

                entity.Property(e => e.BsRachat).HasColumnName("BS_RACHAT");

                entity.Property(e => e.CheminFichierDonnee)
                    .HasColumnType("character varying")
                    .HasColumnName("CHEMIN_FICHIER_DONNEE");

                entity.Property(e => e.CodePostal)
                    .HasColumnType("character varying")
                    .HasColumnName("CODE_POSTAL");

                entity.Property(e => e.CodeRgltComptant)
                    .HasColumnType("character varying")
                    .HasColumnName("CODE_RGLT_COMPTANT");

                entity.Property(e => e.CodeRgltEspece)
                    .HasColumnType("character varying")
                    .HasColumnName("CODE_RGLT_ESPECE");

                entity.Property(e => e.CodeSoc)
                    .HasColumnType("character varying")
                    .HasColumnName("CODE_SOC");

                entity.Property(e => e.CodeTva)
                    .HasColumnType("character varying")
                    .HasColumnName("CODE_TVA");

                entity.Property(e => e.ControlBalckliste)
                    .HasColumnType("character varying")
                    .HasColumnName("CONTROL_BALCKLISTE");

                entity.Property(e => e.CreditMax).HasColumnName("CREDIT_MAX");

                entity.Property(e => e.CtrlConformEcts)
                    .HasColumnName("CTRL_CONFORM_ECTS")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CtrlFinStat)
                    .HasColumnType("character varying")
                    .HasColumnName("CTRL_FIN_STAT")
                    .HasDefaultValueSql("'N'::character varying");

                entity.Property(e => e.DateCr).HasColumnName("DATE_CR");

                entity.Property(e => e.DateDebutSaison).HasColumnName("DATE_DEBUT_SAISON");

                entity.Property(e => e.DateMaj).HasColumnName("DATE_MAJ");

                entity.Property(e => e.Datedemarragecs).HasColumnName("DATEDEMARRAGECS");

                entity.Property(e => e.DelibResultats)
                    .HasColumnType("character varying")
                    .HasColumnName("DELIB_RESULTATS")
                    .HasDefaultValueSql("'N'::character varying");

                entity.Property(e => e.DureePfe).HasColumnName("DUREE_PFE");

                entity.Property(e => e.EMail)
                    .HasColumnType("character varying")
                    .HasColumnName("E_MAIL");

                entity.Property(e => e.FaxSoc)
                    .HasColumnType("character varying")
                    .HasColumnName("FAX_SOC");

                entity.Property(e => e.FrScolariteCj).HasColumnName("FR_SCOLARITE_CJ");

                entity.Property(e => e.FrScolariteCs).HasColumnName("FR_SCOLARITE_CS");

                entity.Property(e => e.GererSemestre)
                    .HasColumnType("character varying")
                    .HasColumnName("GERER_SEMESTRE");

                entity.Property(e => e.IdDiret)
                    .HasColumnType("character varying")
                    .HasColumnName("ID_DIRET");

                entity.Property(e => e.IdServScolaire)
                    .HasColumnType("character varying")
                    .HasColumnName("ID_SERV_SCOLAIRE");

                entity.Property(e => e.IdVacataire)
                    .HasColumnType("character varying")
                    .HasColumnName("ID_VACATAIRE");

                entity.Property(e => e.LiaisonFinancier)
                    .HasColumnType("character varying")
                    .HasColumnName("LIAISON_FINANCIER");

                entity.Property(e => e.LiaisonSite)
                    .HasColumnType("character varying")
                    .HasColumnName("LIAISON_SITE");

                entity.Property(e => e.MaxTauxCreditAccepte).HasColumnName("MAX_TAUX_CREDIT_ACCEPTE");

                entity.Property(e => e.MaxValCreditAccepte).HasColumnName("MAX_VAL_CREDIT_ACCEPTE");

                entity.Property(e => e.MinMoyResussite).HasColumnName("MIN_MOY_RESUSSITE");

                entity.Property(e => e.MinPanier).HasColumnName("MIN_PANIER");

                entity.Property(e => e.NbMaxAbsModule).HasColumnName("NB_MAX_ABS_MODULE");

                entity.Property(e => e.NbSceanceJour).HasColumnName("NB_SCEANCE_JOUR");

                entity.Property(e => e.NbhSemaine).HasColumnName("NBH_SEMAINE");

                entity.Property(e => e.NomSoc)
                    .HasColumnType("character varying")
                    .HasColumnName("NOM_SOC");

                entity.Property(e => e.NumSemestreActuel).HasColumnName("NUM_SEMESTRE_ACTUEL");

                entity.Property(e => e.Numpromotioncs).HasColumnName("NUMPROMOTIONCS");

                entity.Property(e => e.QuotaEctsNv).HasColumnName("QUOTA_ECTS_NV");

                entity.Property(e => e.Rc)
                    .HasColumnType("character varying")
                    .HasColumnName("RC");

                entity.Property(e => e.Rib)
                    .HasColumnType("character varying")
                    .HasColumnName("RIB");

                entity.Property(e => e.Sigle)
                    .HasColumnType("character varying")
                    .HasColumnName("SIGLE");

                entity.Property(e => e.Symbole)
                    .HasMaxLength(1)
                    .HasColumnName("SYMBOLE");

                entity.Property(e => e.TauxDs).HasColumnName("TAUX_DS");

                entity.Property(e => e.TauxExam).HasColumnName("TAUX_EXAM");

                entity.Property(e => e.TauxExamWithCc).HasColumnName("TAUX_EXAM_WITH_CC");

                entity.Property(e => e.TauxExamWithTpCc).HasColumnName("TAUX_EXAM_WITH_TP_CC");

                entity.Property(e => e.TauxMaxAbsence).HasColumnName("TAUX_MAX_ABSENCE");

                entity.Property(e => e.TauxOrale).HasColumnName("TAUX_ORALE");

                entity.Property(e => e.TauxRglt).HasColumnName("TAUX_RGLT");

                entity.Property(e => e.TauxTp).HasColumnName("TAUX_TP");

                entity.Property(e => e.TelSoc)
                    .HasColumnType("character varying")
                    .HasColumnName("TEL_SOC");

                entity.Property(e => e.TimbFiscal).HasColumnName("TIMB_FISCAL");

                entity.Property(e => e.TimbreFiscal).HasColumnName("TIMBRE_FISCAL");

                entity.Property(e => e.TotEctsAdmis).HasColumnName("TOT_ECTS_ADMIS");

                entity.Property(e => e.VerrouPlEtude)
                    .HasColumnType("character varying")
                    .HasColumnName("VERROU_PL_ETUDE");

                entity.Property(e => e.VerrouResul)
                    .HasColumnType("character varying")
                    .HasColumnName("VERROU_RESUL")
                    .HasDefaultValueSql("'N'::character varying");

                entity.Property(e => e.Ville)
                    .HasColumnType("character varying")
                    .HasColumnName("VILLE");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
