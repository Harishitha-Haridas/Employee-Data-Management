using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeeDataManagement.Data;
using EmployeeeDataManagement.Model;
using System.Data.SqlClient;
using System.Data;


namespace EmployeeeDataManagement.Services
{
    internal class services
    {
        private readonly SqlConnection _connection;
        public services()
        {
            _connection = ConnectionManager.Connection;
        }
     

        //--------------services for Admin page

        #region Addone function
        public int AddOne(EmployeeData Employee)
        {
            ConnectionManager.EnsureConnectionIsActive();
            var sql = $"INSERT INTO  {nameof(EmployeeData)} ({nameof(EmployeeData.Name)},{nameof(EmployeeData.Phone)}," +
                $" {nameof(EmployeeData.Email)},{nameof(EmployeeData.age)}, {nameof(EmployeeData.sex)}," +
                $" {nameof(EmployeeData.ResidentialLocation)} , {nameof(EmployeeData.JobTitle)}, {nameof(EmployeeData.Depatment)}, {nameof(EmployeeData.JobLocation)}," +
                 $" {nameof(EmployeeData.MaxSalary)}) VALUES" +
                "(@name,@phone,@email,@age,@sex, @ResidentialLocation,@JobTitle,@Depatment, @JobLocation, @MaxSalary)";
            var cmd = new SqlCommand(sql, _connection);
            cmd.Parameters.AddWithValue("@name", Employee.Name);
            cmd.Parameters.AddWithValue("@phone", Employee.Phone);
            cmd.Parameters.AddWithValue("@email", Employee.Email);
            cmd.Parameters.AddWithValue("@age", Employee.age);

            cmd.Parameters.AddWithValue("@sex", Employee.sex);
            cmd.Parameters.AddWithValue("@ResidentialLocation", Employee.ResidentialLocation);
            cmd.Parameters.AddWithValue("@JobTitle", Employee.JobTitle);
            cmd.Parameters.AddWithValue("@Depatment", Employee.Depatment);

            cmd.Parameters.AddWithValue("@JobLocation", Employee.JobLocation);
            cmd.Parameters.AddWithValue("@MaxSalary", Employee.MaxSalary);
            cmd.Parameters.AddWithValue("@ApplicableSalary", Employee.ApplicableSalary);
      
            return cmd.ExecuteNonQuery();
        }
        #endregion

        #region View by id 
        public EmployeeData GetByIdOnly(int id)
        {
            ConnectionManager.EnsureConnectionIsActive();
           // var sql = $"SELECT {nameof(Users.Id)}, {nameof(Users.Name)}, {nameof(Users.Email)}, {nameof(Users.Phone)}, {nameof(Users.Age)} FROM {nameof(Users)} WHERE {nameof(Users.Id)} = @id";

            var sql = $"SELECT  {nameof(EmployeeData.ID)},{nameof(EmployeeData.Name)},{nameof(EmployeeData.Phone)}," +
                $" {nameof(EmployeeData.Email)},{nameof(EmployeeData.age)}, {nameof(EmployeeData.sex)}," +
                $" {nameof(EmployeeData.ResidentialLocation)} , {nameof(EmployeeData.JobTitle)}, {nameof(EmployeeData.Depatment)}, {nameof(EmployeeData.JobLocation)}," +
                 $" {nameof(EmployeeData.MaxSalary)},{nameof(EmployeeData.ApplicableSalary)},{nameof(EmployeeData.Password)} FROM {nameof(EmployeeData)} WHERE {nameof(EmployeeData.ID)} = @id ";     // and {nameof(EmployeeData.Name)} = @Name


            var cmd = new SqlCommand(sql, _connection);
            cmd.Parameters.AddWithValue("@id", id);
            // cmd.Parameters.AddWithValue("@Name", Name);
            string? s = null;
          
            SqlDataReader? reader = cmd.ExecuteReader();
            //reader.Open();
            var Employee = new EmployeeData();
            if (reader != null)
            {
                while (reader.Read())
                {
                    Employee.ID = reader.GetInt32(0);
                    Employee.Name = reader.GetString(1);
                    Employee.Phone = reader.GetString(2);
                    Employee.Email = reader.GetString(3);

                    Employee.age = reader.GetInt32(4);

                    Employee.sex = reader.GetString(5);
                    Employee.ResidentialLocation = reader.GetString(6);
                    Employee.JobTitle = reader.GetString(7);
                    Employee.Depatment = reader.GetString(8);
                    Employee.JobLocation = reader.GetString(9);


                    Employee.MaxSalary = reader.GetInt32(10);
                    Employee.ApplicableSalary = reader.GetInt32(11);
                    Employee.Password = reader.GetString(12);
                
                }
            }
            reader.Close();
            return Employee;
        }
        #endregion

        #region update function button in admin 
        public int UpdateJobDetails(int IDno, string title, string loc, string departmet,int max)
        {
            ConnectionManager.EnsureConnectionIsActive();
           
            var sql = $"UPDATE {nameof(EmployeeData)} SET   {nameof(EmployeeData.JobTitle)}=@JobTitle , {nameof(EmployeeData.Depatment)}=@Depatment , {nameof(EmployeeData.JobLocation)}= @JobLocation ," +
                 $" {nameof(EmployeeData.MaxSalary)}=  @MaxSalary WHERE {nameof(EmployeeData.ID)} = @id "; //and {nameof(EmployeeData.Name)} = @Name

            //  "(@name,@phone,@email,@age,@sex, @ResidentialLocation,@JobTitle,@Depatment, @JobLocation, @MaxSalary)";
            var cmd = new SqlCommand(sql, _connection);
            cmd.Parameters.AddWithValue("@id", IDno);
          //  cmd.Parameters.AddWithValue("@name", Name);
           
     
            cmd.Parameters.AddWithValue("@JobTitle", title);
            cmd.Parameters.AddWithValue("@Depatment", departmet);

            cmd.Parameters.AddWithValue("@JobLocation", loc);
            cmd.Parameters.AddWithValue("@MaxSalary", max);
            

            return cmd.ExecuteNonQuery();
        }
        #endregion 

        #region  ALL GRID VIEW
        public DataView GridViewAll()
        {
            ConnectionManager.EnsureConnectionIsActive();
            // var sql = $"SELECT {nameof(Users.Id)}, {nameof(Users.Name)}, {nameof(Users.Email)}, {nameof(Users.Phone)}, {nameof(Users.Age)} FROM {nameof(Users)} WHERE {nameof(Users.Id)} = @id";

            var sql = $"SELECT  {nameof(EmployeeData.ID)},{nameof(EmployeeData.Name)},{nameof(EmployeeData.Phone)}," +
                $" {nameof(EmployeeData.Email)},{nameof(EmployeeData.age)}, {nameof(EmployeeData.sex)}," +
                $" {nameof(EmployeeData.ResidentialLocation)} , {nameof(EmployeeData.JobTitle)}, {nameof(EmployeeData.Depatment)}, {nameof(EmployeeData.JobLocation)}," +
                 $" {nameof(EmployeeData.MaxSalary)} as 'Maximum Salary' FROM {nameof(EmployeeData)} ";

            var da = new SqlDataAdapter(sql, _connection);
            DataSet ds = new DataSet();
            da.Fill(ds, nameof(EmployeeData));
            var d = new DataView(ds.Tables[nameof(EmployeeData)]);
            return d;

        }

        #endregion

        #region SORT BY GRID VIEW
        public DataView SoatByView( string s1, string s2)
        {
            ConnectionManager.EnsureConnectionIsActive();
            switch (s1)
            {
                case "Job Title":
                    var sql = $"SELECT  {nameof(EmployeeData.ID)},{nameof(EmployeeData.Name)},{nameof(EmployeeData.Phone)}," +
                   $" {nameof(EmployeeData.Email)},{nameof(EmployeeData.age)}, {nameof(EmployeeData.sex)}," +
                  $" {nameof(EmployeeData.ResidentialLocation)} , {nameof(EmployeeData.JobTitle)}, {nameof(EmployeeData.Depatment)}, {nameof(EmployeeData.JobLocation)}," +
                   $" {nameof(EmployeeData.MaxSalary)}  as 'Maximum Salary' FROM {nameof(EmployeeData)} WHERE  {nameof(EmployeeData.JobTitle)}='{s2}' ";

                    var da = new SqlDataAdapter(sql, _connection);
                    DataSet ds = new DataSet();
                    da.Fill(ds, nameof(EmployeeData));
                    var d = new DataView(ds.Tables[nameof(EmployeeData)]);
                    return d;
                  
                case "Department":
                     sql = $"SELECT  {nameof(EmployeeData.ID)},{nameof(EmployeeData.Name)},{nameof(EmployeeData.Phone)}," +
                $" {nameof(EmployeeData.Email)},{nameof(EmployeeData.age)}, {nameof(EmployeeData.sex)}," +
               $" {nameof(EmployeeData.ResidentialLocation)} , {nameof(EmployeeData.JobTitle)}, {nameof(EmployeeData.Depatment)}, {nameof(EmployeeData.JobLocation)}," +
                $" {nameof(EmployeeData.MaxSalary)}  as 'Maximum Salary' FROM {nameof(EmployeeData)} WHERE  {nameof(EmployeeData.Depatment)}='{s2}' ";

                     da = new SqlDataAdapter(sql, _connection);
                     ds = new DataSet();
                    da.Fill(ds, nameof(EmployeeData));
                     d = new DataView(ds.Tables[nameof(EmployeeData)]);
                    return d;

                   
                case "Job Location":
                    sql = $"SELECT  {nameof(EmployeeData.ID)},{nameof(EmployeeData.Name)},{nameof(EmployeeData.Phone)}," +
              $" {nameof(EmployeeData.Email)},{nameof(EmployeeData.age)}, {nameof(EmployeeData.sex)}," +
             $" {nameof(EmployeeData.ResidentialLocation)} , {nameof(EmployeeData.JobTitle)}, {nameof(EmployeeData.Depatment)}, {nameof(EmployeeData.JobLocation)}," +
              $" {nameof(EmployeeData.MaxSalary)}  as 'Maximum Salary' FROM {nameof(EmployeeData)} WHERE {nameof(EmployeeData.JobLocation)}='{s2}' ";
                   // cmd.Parameters.AddWithValue("@data", s2);
                    da = new SqlDataAdapter(sql, _connection);
                    ds = new DataSet();
                    da.Fill(ds, nameof(EmployeeData));
                    d = new DataView(ds.Tables[nameof(EmployeeData)]);
                    return d;
                default:
                     sql = $"SELECT  {nameof(EmployeeData.ID)},{nameof(EmployeeData.Name)},{nameof(EmployeeData.Phone)}," +
                        $" {nameof(EmployeeData.Email)},{nameof(EmployeeData.age)}, {nameof(EmployeeData.sex)}," +
                        $" {nameof(EmployeeData.ResidentialLocation)} , {nameof(EmployeeData.JobTitle)}, {nameof(EmployeeData.Depatment)}, {nameof(EmployeeData.JobLocation)}," +
                         $" {nameof(EmployeeData.MaxSalary)}  as 'Maximum Salary' FROM {nameof(EmployeeData)} ";

                     da = new SqlDataAdapter(sql, _connection);
                     ds = new DataSet();
                    da.Fill(ds, nameof(EmployeeData));
                     d = new DataView(ds.Tables[nameof(EmployeeData)]);
                    return d;
            }
            
           


               
            
        }
        #endregion

        #region Delete
        public int DeleteEmployee(int IDno, string Name)
        {
            ConnectionManager.EnsureConnectionIsActive();
            var sql = $"DELETE FROM {nameof(EmployeeData)} WHERE {nameof(EmployeeData.ID)} = @id and {nameof(EmployeeData.Name)} = @Name "; //

            //  "(@name,@phone,@email,@age,@sex, @ResidentialLocation,@JobTitle,@Depatment, @JobLocation, @MaxSalary)";
            var cmd = new SqlCommand(sql, _connection);
            cmd.Parameters.AddWithValue("@id", IDno);
            cmd.Parameters.AddWithValue("@name", Name);
            return cmd.ExecuteNonQuery();

        }
        #endregion

        #region Fetching all Titles
        public List<String> GetAllJobtitles()
        {
            ConnectionManager.EnsureConnectionIsActive();
            var sql = $"SELECT {nameof(JobTitle.JobTitiles)} FROM {nameof(JobTitle)}";
            var cmd = new SqlCommand(sql, _connection);
            var reader = cmd.ExecuteReader();

            var Titles = new List<String>();
            while (reader.Read())
            {
                string t = reader.GetString(0);                
                 Titles.Add(t);
            }
            reader.Close();
            return Titles;
        }
        #endregion

        #region AddJob
        
             public int AddJob(String Job)
             {
            ConnectionManager.EnsureConnectionIsActive();
           
            var sql = $"INSERT INTO {nameof(JobTitle)} ({nameof(JobTitle.JobTitiles)}) VALUES (@JobTitle)";
           // var sql = $"SELECT {nameof(JobTitle.JobTitiles)} FROM {nameof(JobTitle)}";
            var cmd = new SqlCommand(sql, _connection);
            cmd.Parameters.AddWithValue("@JobTitle", Job);
            

            return cmd.ExecuteNonQuery();
              }

        #endregion

        #region Fetching all IDS
        public List<int> GetAllIDs()
        {
            ConnectionManager.EnsureConnectionIsActive();
            var sql = $"SELECT {nameof(EmployeeData.ID)} FROM {nameof(EmployeeData)}";
           
            var cmd = new SqlCommand(sql, _connection);
            var reader = cmd.ExecuteReader();

            var IdAll = new List<int>();
            while (reader.Read())
            {
                int t = reader.GetInt32(0);
                IdAll.Add(t);
            }
            reader.Close();
            return IdAll;
        }
        #endregion

        #region CALCULATING SALARY
        public int Calsalary(int ID,int month, int Year)
        { 
            int max = 0, no_leave = 0;
            long perday, App;
            ConnectionManager.EnsureConnectionIsActive();
            var sql1 = $"SELECT {nameof(EmployeeData.MaxSalary)} FROM {nameof(EmployeeData)} " +
                $" WHERE {nameof(EmployeeData.ID)} = @ID";
            var cmd1 = new SqlCommand(sql1, _connection);
            cmd1.Parameters.AddWithValue("@ID", ID);
            var reader1 = cmd1.ExecuteReader();
            while (reader1.Read())
            {
                max = reader1.GetInt32(0);
               
            }
            reader1.Close();
         
            ConnectionManager.EnsureConnectionIsActive();
            var sql2 = $"SELECT COUNT(*)  FROM {nameof(Leave)} WHERE {nameof(Leave.EmpId)}=@ID and" +
                $" {nameof(Leave.LMonth)}=@month and {nameof(Leave.LYear)}=@Year";
            var cmd2 = new SqlCommand(sql2, _connection);

            cmd2.Parameters.AddWithValue("@ID", ID);
            cmd2.Parameters.AddWithValue("@month", month);
            cmd2.Parameters.AddWithValue("@Year", Year);

            var reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {
                no_leave = reader2.GetInt32(0);

            }
            reader2.Close();

            perday = (max / 30)* no_leave;

            App = max - perday;

            ConnectionManager.EnsureConnectionIsActive();
     
            var sql3 = $"INSERT INTO {nameof(SalaryTable)} ({nameof(SalaryTable.EmpId)} , {nameof(SalaryTable.SMonth)} ," +
                $" {nameof(SalaryTable.SYear)} , {nameof(SalaryTable.ApplicableSalary)}) VALUES (@ID , @month , @year ,@app)";
            // var sql = $"SELECT {nameof(JobTitle.JobTitiles)} FROM {nameof(JobTitle)}";
            var cmd3 = new SqlCommand(sql3, _connection);
            cmd3.Parameters.AddWithValue("@ID", ID);
            cmd3.Parameters.AddWithValue("@month", month);
            cmd3.Parameters.AddWithValue("@year", Year);
            cmd3.Parameters.AddWithValue("@app", App);

            return cmd3.ExecuteNonQuery();

        }
        #endregion

        #region   GRID VIEW for salary details

        public DataView GridViewSalary(int month, int year)
        {
            ConnectionManager.EnsureConnectionIsActive();
            // var sql = $"SELECT {nameof(Users.Id)}, {nameof(Users.Name)}, {nameof(Users.Email)}, {nameof(Users.Phone)}, {nameof(Users.Age)} FROM {nameof(Users)} WHERE {nameof(Users.Id)} = @id";

            var sql = $"SELECT  {nameof(EmployeeData)}.{nameof(EmployeeData.ID)}, {nameof(EmployeeData)}.{nameof(EmployeeData.Name)}," +
                $"  {nameof(EmployeeData)}.{nameof(EmployeeData.JobTitle)}, {nameof(EmployeeData)}.{nameof(EmployeeData.Depatment)} , {nameof(EmployeeData)}.{nameof(EmployeeData.JobLocation)}, " +
                $"{nameof(SalaryTable)}.{nameof(SalaryTable.SMonth)} , {nameof(SalaryTable)}.{nameof(SalaryTable.SYear)} ,{nameof(SalaryTable)}.{nameof(SalaryTable.ApplicableSalary)} " +
                 $" FROM {nameof(EmployeeData)} inner join {nameof(SalaryTable)}  on {nameof(EmployeeData)}.{nameof(EmployeeData.ID)} = {nameof(SalaryTable)}.{nameof(SalaryTable.EmpId)} " +
                 $" WHERE  {nameof(SalaryTable)}.{nameof(SalaryTable.SYear)} ={year} and {nameof(SalaryTable)}.{nameof(SalaryTable.SMonth)} = {month}";

            //cmd.Parameters.AddWithValue("@year", year);
            //cmd.Parameters.AddWithValue("@month", month);

            var da = new SqlDataAdapter(sql, _connection);
            DataSet ds = new DataSet();
            da.Fill(ds, nameof(EmployeeData));
            var d = new DataView(ds.Tables[nameof(EmployeeData)]);
            return d;

        }

        #endregion


        //_______service for login page

        #region Login
        public int GetByNamePassword(String U_Name, String U_Password)
        {
            int k = 0;
            ConnectionManager.EnsureConnectionIsActive();

         //   var sql = $"SELECT  {nameof(EmployeeData.ID)} FROM {nameof(EmployeeData)} WHERE {nameof(EmployeeData.Password)} = 'abcd' and {nameof(EmployeeData.Name)} ='geetha' ";
         // select id from employeetdata whre pass= and user=name
           var sql = $"SELECT  {nameof(EmployeeData.ID)} FROM {nameof(EmployeeData)} WHERE {nameof(EmployeeData.Password)} = @Password and {nameof(EmployeeData.Name)} = @Name ";
              var cmd = new SqlCommand(sql, _connection);
            cmd.Parameters.AddWithValue("@Password", U_Password);
            cmd.Parameters.AddWithValue("@Name", U_Name);

            SqlDataReader? reader = cmd.ExecuteReader();
            //reader.Open();
            var Employee = new EmployeeData();
            if (reader != null)
            {
                while (reader.Read())
                {
                    Employee.ID = reader.GetInt32(0);
                }
                k = Employee.ID;
            }
           
            reader.Close();
            return k;
        }
        #endregion

        //_______service for employee


        #region update function button in admin 
        public int UpdatePersonDetails(int IDno, string Email, string Phone, string Rloc, string Gender)
        {
          

            ConnectionManager.EnsureConnectionIsActive();
            var sql = $"UPDATE {nameof(EmployeeData)} SET   {nameof(EmployeeData.Email)}=@Email , { nameof(EmployeeData.Phone)}=@Phone ,{nameof(EmployeeData.sex)}= @Gender ," +
                 $" {nameof(EmployeeData.ResidentialLocation)} =  @Rloc WHERE {nameof(EmployeeData.ID)} = @id "; 
            var cmd = new SqlCommand(sql, _connection);
            cmd.Parameters.AddWithValue("@id", IDno);
           
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@Phone", Phone);

            cmd.Parameters.AddWithValue("@Rloc", Rloc);
            cmd.Parameters.AddWithValue("@Gender", Gender);


            return cmd.ExecuteNonQuery();
        }
        #endregion

        #region update Password
        public int UpdatePassword(int IDno, string Password)
        {


            ConnectionManager.EnsureConnectionIsActive();
            var sql = $"UPDATE {nameof(EmployeeData)} SET   {nameof(EmployeeData.Password)}= @Password " +
                 $"  WHERE {nameof(EmployeeData.ID)} = @id ";
            var cmd = new SqlCommand(sql, _connection);

            cmd.Parameters.AddWithValue("@id", IDno);

            cmd.Parameters.AddWithValue("@Password", Password);
        


            return cmd.ExecuteNonQuery();
        }
        #endregion


        #region Insert Leave
        public int InserLeave(Leave lv)
        {
            ConnectionManager.EnsureConnectionIsActive();
            var sql = $"INSERT INTO {nameof(Leave)} ({nameof(Leave.EmpId)},{nameof(Leave.LDay)}," +
                $" {nameof(Leave.LMonth)},{nameof(Leave.LYear)}, {nameof(Leave.Date)}," +
                 $" {nameof(Leave.Lreason)}) VALUES" +
                "(@EmpId,@LDay ,@LMonth,@LYear,@Date, @Lreason)";
            var cmd = new SqlCommand(sql, _connection);
            cmd.Parameters.AddWithValue("@EmpId", lv.EmpId);
            cmd.Parameters.AddWithValue("@LDay ", lv.LDay);
            cmd.Parameters.AddWithValue("@LMonth", lv.LMonth);
            cmd.Parameters.AddWithValue("@LYear", lv.LYear);
            cmd.Parameters.AddWithValue("@Date", lv.Date);
            cmd.Parameters.AddWithValue("@Lreason", lv.Lreason);

            return cmd.ExecuteNonQuery();
        }



        #endregion

        #region   GRID VIEW salary details
        public DataView GridSalary(int Id)
        {
            ConnectionManager.EnsureConnectionIsActive();
            

            var sql = $"SELECT  {nameof(SalaryTable.EmpId)} AS 'Employee Id' , {nameof(SalaryTable.SMonth)} AS 'Month' , {nameof(SalaryTable.SYear)} As 'Year' ," +
                $" {nameof(SalaryTable.ApplicableSalary)} FROM {nameof(SalaryTable)} Where {nameof(SalaryTable.EmpId)} = {Id} ";

            var da = new SqlDataAdapter(sql, _connection);
            DataSet ds = new DataSet();
            da.Fill(ds, nameof(SalaryTable));
            var d = new DataView(ds.Tables[nameof(SalaryTable)]);
            return d;

        }

        #endregion

        #region   GRID VIEW Leave details
        public DataView GridLeave(int Id)
        {
            ConnectionManager.EnsureConnectionIsActive();
          
            var sql = $"SELECT  {nameof(Leave.EmpId)} as 'Employee ID' ,{nameof(Leave.Date)} as 'Date' ,{nameof(Leave.Lreason)} as 'Reason' " +
               $" FROM {nameof(Leave)} Where {nameof(Leave.EmpId)} = {Id} ";

                var da = new SqlDataAdapter(sql, _connection);
            DataSet ds = new DataSet();
            da.Fill(ds, nameof(Leave));
            var d = new DataView(ds.Tables[nameof(Leave)]);
            return d;

        }

        #endregion



    }
}

        

