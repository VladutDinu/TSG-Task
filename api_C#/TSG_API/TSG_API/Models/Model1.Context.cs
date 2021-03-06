//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TSG_API.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class TSGEntities : DbContext
    {
        public TSGEntities()
            : base("name=TSGEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Personal_TSG> Personal_TSG { get; set; }
        public virtual DbSet<Echipe_TSG> Echipe_TSG { get; set; }
        public virtual DbSet<Personal_Proiecte_TSG> Personal_Proiecte_TSG { get; set; }
        public virtual DbSet<Proiecte_TSG> Proiecte_TSG { get; set; }
        public virtual DbSet<Venit_Personal_TSG> Venit_Personal_TSG { get; set; }
    
        public virtual int CreateEchipe_TSG(Nullable<int> iD_TeamLeader)
        {
            var iD_TeamLeaderParameter = iD_TeamLeader.HasValue ?
                new ObjectParameter("ID_TeamLeader", iD_TeamLeader) :
                new ObjectParameter("ID_TeamLeader", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CreateEchipe_TSG", iD_TeamLeaderParameter);
        }
    
        public virtual int CreatePersonal_Proiecte_TSG(Nullable<int> iD_Personal, Nullable<int> iD_Proiect)
        {
            var iD_PersonalParameter = iD_Personal.HasValue ?
                new ObjectParameter("ID_Personal", iD_Personal) :
                new ObjectParameter("ID_Personal", typeof(int));
    
            var iD_ProiectParameter = iD_Proiect.HasValue ?
                new ObjectParameter("ID_Proiect", iD_Proiect) :
                new ObjectParameter("ID_Proiect", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CreatePersonal_Proiecte_TSG", iD_PersonalParameter, iD_ProiectParameter);
        }
    
        public virtual int CreatePersonal_TSG(string nume, Nullable<int> iD_Proiect)
        {
            var numeParameter = nume != null ?
                new ObjectParameter("Nume", nume) :
                new ObjectParameter("Nume", typeof(string));
    
            var iD_ProiectParameter = iD_Proiect.HasValue ?
                new ObjectParameter("ID_Proiect", iD_Proiect) :
                new ObjectParameter("ID_Proiect", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CreatePersonal_TSG", numeParameter, iD_ProiectParameter);
        }
    
        public virtual int CreateProiecte_TSG(string proiect)
        {
            var proiectParameter = proiect != null ?
                new ObjectParameter("Proiect", proiect) :
                new ObjectParameter("Proiect", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CreateProiecte_TSG", proiectParameter);
        }
    
        public virtual int CreateVenit_Personal_TSG(Nullable<int> iD_Personal, Nullable<double> venit)
        {
            var iD_PersonalParameter = iD_Personal.HasValue ?
                new ObjectParameter("ID_Personal", iD_Personal) :
                new ObjectParameter("ID_Personal", typeof(int));
    
            var venitParameter = venit.HasValue ?
                new ObjectParameter("Venit", venit) :
                new ObjectParameter("Venit", typeof(double));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CreateVenit_Personal_TSG", iD_PersonalParameter, venitParameter);
        }
    
        public virtual int DeleteEchipe_TSG(string iD_Echipa)
        {
            var iD_EchipaParameter = iD_Echipa != null ?
                new ObjectParameter("ID_Echipa", iD_Echipa) :
                new ObjectParameter("ID_Echipa", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteEchipe_TSG", iD_EchipaParameter);
        }
    
        public virtual int DeletePersonal_Proiecte_TSG(Nullable<int> iD_Proiect)
        {
            var iD_ProiectParameter = iD_Proiect.HasValue ?
                new ObjectParameter("ID_Proiect", iD_Proiect) :
                new ObjectParameter("ID_Proiect", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeletePersonal_Proiecte_TSG", iD_ProiectParameter);
        }
    
        public virtual int DeletePersonal_TSG(string nume)
        {
            var numeParameter = nume != null ?
                new ObjectParameter("Nume", nume) :
                new ObjectParameter("Nume", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeletePersonal_TSG", numeParameter);
        }
    
        public virtual int DeleteProiecte_TSG(string proiect)
        {
            var proiectParameter = proiect != null ?
                new ObjectParameter("Proiect", proiect) :
                new ObjectParameter("Proiect", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteProiecte_TSG", proiectParameter);
        }
    
        public virtual int DeleteVenit_Personal_TSG(Nullable<int> iD_Personal)
        {
            var iD_PersonalParameter = iD_Personal.HasValue ?
                new ObjectParameter("ID_Personal", iD_Personal) :
                new ObjectParameter("ID_Personal", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteVenit_Personal_TSG", iD_PersonalParameter);
        }
    
        public virtual ObjectResult<JoinMany_To_Many_Result> JoinMany_To_Many()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<JoinMany_To_Many_Result>("JoinMany_To_Many");
        }
    
        public virtual ObjectResult<JoinOne_To_Many_Result> JoinOne_To_Many()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<JoinOne_To_Many_Result>("JoinOne_To_Many");
        }
    
        public virtual ObjectResult<JoinOne_To_One_Result> JoinOne_To_One()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<JoinOne_To_One_Result>("JoinOne_To_One");
        }
    
        public virtual ObjectResult<SelectEchipe_TSG_Result> SelectEchipe_TSG()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SelectEchipe_TSG_Result>("SelectEchipe_TSG");
        }
    
        public virtual ObjectResult<SelectPersonal_Proiecte_TSG_Result> SelectPersonal_Proiecte_TSG()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SelectPersonal_Proiecte_TSG_Result>("SelectPersonal_Proiecte_TSG");
        }
    
        public virtual ObjectResult<SelectPersonal_TSG_Result> SelectPersonal_TSG()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SelectPersonal_TSG_Result>("SelectPersonal_TSG");
        }
    
        public virtual ObjectResult<SelectProiecte_TSG_Result> SelectProiecte_TSG()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SelectProiecte_TSG_Result>("SelectProiecte_TSG");
        }
    
        public virtual ObjectResult<SelectVenit_Personal_TSG_Result> SelectVenit_Personal_TSG()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SelectVenit_Personal_TSG_Result>("SelectVenit_Personal_TSG");
        }
    
        public virtual int UpdateEchipe_TSG(Nullable<int> iD_Echipa, Nullable<int> iD_TeamLeader)
        {
            var iD_EchipaParameter = iD_Echipa.HasValue ?
                new ObjectParameter("ID_Echipa", iD_Echipa) :
                new ObjectParameter("ID_Echipa", typeof(int));
    
            var iD_TeamLeaderParameter = iD_TeamLeader.HasValue ?
                new ObjectParameter("ID_TeamLeader", iD_TeamLeader) :
                new ObjectParameter("ID_TeamLeader", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateEchipe_TSG", iD_EchipaParameter, iD_TeamLeaderParameter);
        }
    
        public virtual int UpdatePersonal_Proiecte_TSG(Nullable<int> iD_Personal, Nullable<int> iD_Proiect)
        {
            var iD_PersonalParameter = iD_Personal.HasValue ?
                new ObjectParameter("ID_Personal", iD_Personal) :
                new ObjectParameter("ID_Personal", typeof(int));
    
            var iD_ProiectParameter = iD_Proiect.HasValue ?
                new ObjectParameter("ID_Proiect", iD_Proiect) :
                new ObjectParameter("ID_Proiect", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdatePersonal_Proiecte_TSG", iD_PersonalParameter, iD_ProiectParameter);
        }
    
        public virtual int UpdatePersonal_TSG(Nullable<int> iD_Proiect, string nume)
        {
            var iD_ProiectParameter = iD_Proiect.HasValue ?
                new ObjectParameter("ID_Proiect", iD_Proiect) :
                new ObjectParameter("ID_Proiect", typeof(int));
    
            var numeParameter = nume != null ?
                new ObjectParameter("Nume", nume) :
                new ObjectParameter("Nume", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdatePersonal_TSG", iD_ProiectParameter, numeParameter);
        }
    
        public virtual int UpdateProiecte_TSG(string nouProiect, string proiect)
        {
            var nouProiectParameter = nouProiect != null ?
                new ObjectParameter("NouProiect", nouProiect) :
                new ObjectParameter("NouProiect", typeof(string));
    
            var proiectParameter = proiect != null ?
                new ObjectParameter("Proiect", proiect) :
                new ObjectParameter("Proiect", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateProiecte_TSG", nouProiectParameter, proiectParameter);
        }
    
        public virtual int UpdateVenit_Personal_TSG(Nullable<int> iD_Personal, Nullable<double> venit)
        {
            var iD_PersonalParameter = iD_Personal.HasValue ?
                new ObjectParameter("ID_Personal", iD_Personal) :
                new ObjectParameter("ID_Personal", typeof(int));
    
            var venitParameter = venit.HasValue ?
                new ObjectParameter("Venit", venit) :
                new ObjectParameter("Venit", typeof(double));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateVenit_Personal_TSG", iD_PersonalParameter, venitParameter);
        }
    }
}
