using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Dapper;

namespace Eval.Models
{
    public static class BD
    {
        private static string _connectionString = @"Server=.; DataBase=BDEscuelas;Trusted_Connection=True;";

        public static List<Docente> GetDocentes()
        {
            List<Docente> Lista = null;
            string SQL = "SELECT * FROM Docentes"; 
            using(SqlConnection db = new SqlConnection(_connectionString))
            {
                Lista = db.Query<Docente>(SQL).ToList(); 
            } 
            return Lista;
        }
        public static Docente GetDocenteById(int Id)
        {
            Docente item = null;
            string SQL = "SELECT * FROM Docentes D INNER JOIN Materias M ON D.IdMateria=M.IdMateria"; 
            SQL += " WHERE IdDocente=@pId"; 
            using(SqlConnection db = new SqlConnection(_connectionString))
            {
                item = db.QueryFirstOrDefault<Docente>(SQL, new { pId = Id }); 
            } 
            return item;
        }
        public static bool GetDocenteByIdMateria(int IdMateria)
        {
            Docente item = null;
            string SQL = "SELECT * FROM Docentes WHERE IdMateria=@pIdMateria"; 
            using(SqlConnection db = new SqlConnection(_connectionString))
            {
                item = db.QueryFirstOrDefault<Docente>(SQL, new { pIdMateria = IdMateria }); 
            } 
            return (item != null);
        }
        public static void DeleteDocenteById(int Id)
        {
            string SQL = "DELETE FROM Docentes WHERE IdDocente=@pId"; 
            using(SqlConnection db = new SqlConnection(_connectionString))
            {
                db.Execute(SQL, new { pId = Id }); 
            } 
        }
        public static List<Materia> GetMaterias()
        {
            List<Materia> Lista = null;
            string SQL = "SELECT * FROM Materias"; 
            using(SqlConnection db = new SqlConnection(_connectionString))
            {
                Lista = db.Query<Materia>(SQL).ToList(); 
            } 
            return Lista;
        }
        public static void InsertDocente(Docente item)
        {
            string SQL = "INSERT INTO Docentes(NombreDocente, FotoDocente, AntiguedadDocente, IdMateria)";
            SQL += " VALUES (@pNombreDocente, @pFotoDocente, @pAntiguedadDocente, @pIdMateria) "; 
            using(SqlConnection db = new SqlConnection(_connectionString))
            {
                db.Execute(SQL, new {
                    pNombreDocente = item.NombreDocente,
                    pFotoDocente = item.FotoDocente,
                    pAntiguedadDocente = item.AntiguedadDocente,
                    pIdMateria = item.IdMateria
                }); 
            }   
        }
    }
}