//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCF_Hunde
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class HundeDBEntities : DbContext
    {
        public HundeDBEntities()
            : base("name=HundeDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Tb_Cliente> Tb_Cliente { get; set; }
        public virtual DbSet<Tb_Empleado> Tb_Empleado { get; set; }
        public virtual DbSet<Tb_Paciente> Tb_Paciente { get; set; }
        public virtual DbSet<Tb_Proveedor> Tb_Proveedor { get; set; }
        public virtual DbSet<Tb_Usuario> Tb_Usuario { get; set; }
        public virtual DbSet<vw_ClientesSonEmpleados> vw_ClientesSonEmpleados { get; set; }
    
        public virtual int usp_ActualizarEmpleado(Nullable<int> vtipo_ciente, string vnom_cliente, string vape_pat_cli, string vape_mat_cli, string vdir_cli, string vcel_cli, string vemail_cli, Nullable<int> ves_dueno, Nullable<int> ves_empleado, string vid_ubigeo, string vdni_cli, string vusu_ult_mod, Nullable<System.DateTime> vfec_ult_mod, Nullable<int> vestado_cli, Nullable<int> vrol_emp, Nullable<System.DateTime> vfecha_ingreso, Nullable<decimal> vsueldo, string vcod_supervisor, Nullable<int> vestado_emp, string vcod_cli, string vcod_emp)
        {
            var vtipo_cienteParameter = vtipo_ciente.HasValue ?
                new ObjectParameter("vtipo_ciente", vtipo_ciente) :
                new ObjectParameter("vtipo_ciente", typeof(int));
    
            var vnom_clienteParameter = vnom_cliente != null ?
                new ObjectParameter("vnom_cliente", vnom_cliente) :
                new ObjectParameter("vnom_cliente", typeof(string));
    
            var vape_pat_cliParameter = vape_pat_cli != null ?
                new ObjectParameter("vape_pat_cli", vape_pat_cli) :
                new ObjectParameter("vape_pat_cli", typeof(string));
    
            var vape_mat_cliParameter = vape_mat_cli != null ?
                new ObjectParameter("vape_mat_cli", vape_mat_cli) :
                new ObjectParameter("vape_mat_cli", typeof(string));
    
            var vdir_cliParameter = vdir_cli != null ?
                new ObjectParameter("vdir_cli", vdir_cli) :
                new ObjectParameter("vdir_cli", typeof(string));
    
            var vcel_cliParameter = vcel_cli != null ?
                new ObjectParameter("vcel_cli", vcel_cli) :
                new ObjectParameter("vcel_cli", typeof(string));
    
            var vemail_cliParameter = vemail_cli != null ?
                new ObjectParameter("vemail_cli", vemail_cli) :
                new ObjectParameter("vemail_cli", typeof(string));
    
            var ves_duenoParameter = ves_dueno.HasValue ?
                new ObjectParameter("ves_dueno", ves_dueno) :
                new ObjectParameter("ves_dueno", typeof(int));
    
            var ves_empleadoParameter = ves_empleado.HasValue ?
                new ObjectParameter("ves_empleado", ves_empleado) :
                new ObjectParameter("ves_empleado", typeof(int));
    
            var vid_ubigeoParameter = vid_ubigeo != null ?
                new ObjectParameter("vid_ubigeo", vid_ubigeo) :
                new ObjectParameter("vid_ubigeo", typeof(string));
    
            var vdni_cliParameter = vdni_cli != null ?
                new ObjectParameter("vdni_cli", vdni_cli) :
                new ObjectParameter("vdni_cli", typeof(string));
    
            var vusu_ult_modParameter = vusu_ult_mod != null ?
                new ObjectParameter("vusu_ult_mod", vusu_ult_mod) :
                new ObjectParameter("vusu_ult_mod", typeof(string));
    
            var vfec_ult_modParameter = vfec_ult_mod.HasValue ?
                new ObjectParameter("vfec_ult_mod", vfec_ult_mod) :
                new ObjectParameter("vfec_ult_mod", typeof(System.DateTime));
    
            var vestado_cliParameter = vestado_cli.HasValue ?
                new ObjectParameter("vestado_cli", vestado_cli) :
                new ObjectParameter("vestado_cli", typeof(int));
    
            var vrol_empParameter = vrol_emp.HasValue ?
                new ObjectParameter("vrol_emp", vrol_emp) :
                new ObjectParameter("vrol_emp", typeof(int));
    
            var vfecha_ingresoParameter = vfecha_ingreso.HasValue ?
                new ObjectParameter("vfecha_ingreso", vfecha_ingreso) :
                new ObjectParameter("vfecha_ingreso", typeof(System.DateTime));
    
            var vsueldoParameter = vsueldo.HasValue ?
                new ObjectParameter("vsueldo", vsueldo) :
                new ObjectParameter("vsueldo", typeof(decimal));
    
            var vcod_supervisorParameter = vcod_supervisor != null ?
                new ObjectParameter("vcod_supervisor", vcod_supervisor) :
                new ObjectParameter("vcod_supervisor", typeof(string));
    
            var vestado_empParameter = vestado_emp.HasValue ?
                new ObjectParameter("vestado_emp", vestado_emp) :
                new ObjectParameter("vestado_emp", typeof(int));
    
            var vcod_cliParameter = vcod_cli != null ?
                new ObjectParameter("vcod_cli", vcod_cli) :
                new ObjectParameter("vcod_cli", typeof(string));
    
            var vcod_empParameter = vcod_emp != null ?
                new ObjectParameter("vcod_emp", vcod_emp) :
                new ObjectParameter("vcod_emp", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_ActualizarEmpleado", vtipo_cienteParameter, vnom_clienteParameter, vape_pat_cliParameter, vape_mat_cliParameter, vdir_cliParameter, vcel_cliParameter, vemail_cliParameter, ves_duenoParameter, ves_empleadoParameter, vid_ubigeoParameter, vdni_cliParameter, vusu_ult_modParameter, vfec_ult_modParameter, vestado_cliParameter, vrol_empParameter, vfecha_ingresoParameter, vsueldoParameter, vcod_supervisorParameter, vestado_empParameter, vcod_cliParameter, vcod_empParameter);
        }
    
        public virtual int usp_InsertarEmpleado(Nullable<int> vtipo_ciente, string vnom_cliente, string vape_pat_cli, string vape_mat_cli, string vdir_cli, string vcel_cli, string vemail_cli, Nullable<int> ves_dueno, Nullable<int> ves_empleado, string vid_ubigeo, string vdni_cli, string vusu_reg_cli, Nullable<int> vestado_cli, Nullable<int> vrol_emp, Nullable<System.DateTime> vfecha_ingreso, Nullable<decimal> vsueldo, string vcod_supervisor, Nullable<int> vestado_emp)
        {
            var vtipo_cienteParameter = vtipo_ciente.HasValue ?
                new ObjectParameter("vtipo_ciente", vtipo_ciente) :
                new ObjectParameter("vtipo_ciente", typeof(int));
    
            var vnom_clienteParameter = vnom_cliente != null ?
                new ObjectParameter("vnom_cliente", vnom_cliente) :
                new ObjectParameter("vnom_cliente", typeof(string));
    
            var vape_pat_cliParameter = vape_pat_cli != null ?
                new ObjectParameter("vape_pat_cli", vape_pat_cli) :
                new ObjectParameter("vape_pat_cli", typeof(string));
    
            var vape_mat_cliParameter = vape_mat_cli != null ?
                new ObjectParameter("vape_mat_cli", vape_mat_cli) :
                new ObjectParameter("vape_mat_cli", typeof(string));
    
            var vdir_cliParameter = vdir_cli != null ?
                new ObjectParameter("vdir_cli", vdir_cli) :
                new ObjectParameter("vdir_cli", typeof(string));
    
            var vcel_cliParameter = vcel_cli != null ?
                new ObjectParameter("vcel_cli", vcel_cli) :
                new ObjectParameter("vcel_cli", typeof(string));
    
            var vemail_cliParameter = vemail_cli != null ?
                new ObjectParameter("vemail_cli", vemail_cli) :
                new ObjectParameter("vemail_cli", typeof(string));
    
            var ves_duenoParameter = ves_dueno.HasValue ?
                new ObjectParameter("ves_dueno", ves_dueno) :
                new ObjectParameter("ves_dueno", typeof(int));
    
            var ves_empleadoParameter = ves_empleado.HasValue ?
                new ObjectParameter("ves_empleado", ves_empleado) :
                new ObjectParameter("ves_empleado", typeof(int));
    
            var vid_ubigeoParameter = vid_ubigeo != null ?
                new ObjectParameter("vid_ubigeo", vid_ubigeo) :
                new ObjectParameter("vid_ubigeo", typeof(string));
    
            var vdni_cliParameter = vdni_cli != null ?
                new ObjectParameter("vdni_cli", vdni_cli) :
                new ObjectParameter("vdni_cli", typeof(string));
    
            var vusu_reg_cliParameter = vusu_reg_cli != null ?
                new ObjectParameter("vusu_reg_cli", vusu_reg_cli) :
                new ObjectParameter("vusu_reg_cli", typeof(string));
    
            var vestado_cliParameter = vestado_cli.HasValue ?
                new ObjectParameter("vestado_cli", vestado_cli) :
                new ObjectParameter("vestado_cli", typeof(int));
    
            var vrol_empParameter = vrol_emp.HasValue ?
                new ObjectParameter("vrol_emp", vrol_emp) :
                new ObjectParameter("vrol_emp", typeof(int));
    
            var vfecha_ingresoParameter = vfecha_ingreso.HasValue ?
                new ObjectParameter("vfecha_ingreso", vfecha_ingreso) :
                new ObjectParameter("vfecha_ingreso", typeof(System.DateTime));
    
            var vsueldoParameter = vsueldo.HasValue ?
                new ObjectParameter("vsueldo", vsueldo) :
                new ObjectParameter("vsueldo", typeof(decimal));
    
            var vcod_supervisorParameter = vcod_supervisor != null ?
                new ObjectParameter("vcod_supervisor", vcod_supervisor) :
                new ObjectParameter("vcod_supervisor", typeof(string));
    
            var vestado_empParameter = vestado_emp.HasValue ?
                new ObjectParameter("vestado_emp", vestado_emp) :
                new ObjectParameter("vestado_emp", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_InsertarEmpleado", vtipo_cienteParameter, vnom_clienteParameter, vape_pat_cliParameter, vape_mat_cliParameter, vdir_cliParameter, vcel_cliParameter, vemail_cliParameter, ves_duenoParameter, ves_empleadoParameter, vid_ubigeoParameter, vdni_cliParameter, vusu_reg_cliParameter, vestado_cliParameter, vrol_empParameter, vfecha_ingresoParameter, vsueldoParameter, vcod_supervisorParameter, vestado_empParameter);
        }
    }
}
