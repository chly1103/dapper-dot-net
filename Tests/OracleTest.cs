using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using Dapper; 

namespace SqlMapper
{
    public class OracleTest
    {
        private OracleConnection connection = Program.GetOracleConnection();

        /*
         
       public void SelectWINDsDynamic()
       {
           var p = new OracleDynamicParameters();
           //对于拼接的字符串需要加上''
//            p.Add("v_WhereCondition", value: "projectid = 'c521123eac544281b43072ab83eea295'", dbType: OracleType.NVarChar);
           p.Add("v_WhereCondition", value: " project_id='c521123eac544281b43072ab83eea295' ", dbType: OracleType.NVarChar);
          p.Add("v_OrderByExpression", value: "'order by north desc'", dbType: OracleType.NVarChar);
         // p.Add("v_OrderByExpression", value: "", dbType: OracleType.NVarChar);
           p.Add("p_cursor", dbType: OracleType.Cursor, direction: ParameterDirection.Output);
           IEnumerable<Winds> lst = connection.Query<Winds>("SelectWINDsDynamic", param: p, commandType: CommandType.StoredProcedure);

       }

                
       public void SelectWINDsByAndPROJECT_ID()
       {
           var p = new OracleDynamicParameters();
           //对于拼接的字符串需要加上''
           p.Add("v_PROJECT_ID", value: "'c521123eac544281b43072ab83eea295'", dbType: OracleType.NVarChar);
           p.Add("p_cursor", dbType: OracleType.Cursor, direction: ParameterDirection.Output);

           var count =
               connection.Query<Winds>("SelectWINDsByAndPROJECT_ID", param: p, commandType: CommandType.StoredProcedure);

           Console.WriteLine(count.Count());

       }

        
       public void SelectWIND()
       {
           var p = new OracleDynamicParameters();
           //对于拼接的字符串需要加上''
           p.Add("v_WINDS_ID", value: "'f37b81e7af9b4735ac1232b5e751ba06'",dbType:OracleType.NVarChar);
           p.Add("p_cursor", dbType: OracleType.Cursor, direction: ParameterDirection.Output);
             
           var count =
               connection.Query<Winds>("SelectWIND", param: p, commandType: CommandType.StoredProcedure).First();

           Console.WriteLine(count.Project_Id);
       }

        
       public void DeleteWINDsDynamic()
       {
           var p =
              new DynamicParameters(
                  new
                  {
                      v_WhereCondition = "winds_id in ('14e9ed96-241e-4e1f-8d6a-e4bf7900c865','95e38ba9-1c9b-4f53-9ed0-322d8a259d62','ae8a4dd1dce14adea04279f6c787314X')"
                  });

           int count = connection.Execute("DeleteWINDsDynamic", param: p, commandType: CommandType.StoredProcedure);

           Console.WriteLine(count);

       }
         
       public void DeleteWIND()
       {
           var p =
               new DynamicParameters(
                   new
                       {
                           v_WINDS_ID = "beb12c41-6d95-4149-af01-f784b6736daf"
                       });

           int count = connection.Execute("DeleteWIND", param: p, commandType: CommandType.StoredProcedure);

           Console.WriteLine(count);
       }

        
       public void InsertUpdateWIND()
       {
           //insert

//             var p = new DynamicParameters(new { v_WINDS_ID = Guid.NewGuid().ToString(), v_PROJECT_ID = "c521123eac544281b43072ab83eea295", v_Windspeed = "3--23", v_North = 22, v_Northnorthwest = 22, v_Northwest = 22, v_Westnorthwest = 22, v_West = 22, v_Westsouthwest = 22, v_Southwest = 22, v_Southsouthwest = 22, v_South = 22, v_Southsoutheast = 22, v_Southeast = 22, v_Eastsoutheast = 22, v_East = 22, v_Eastnortheast = 22, v_Northeast = 22, v_Northnortheast = 22, v_None = 22 });
//
//                          int count = connection.Execute("InsertUpdateWIND", param: p, commandType: CommandType.StoredProcedure);
//
//             Console.WriteLine(count);

           //update

           var p =
               new DynamicParameters(
                   new
                       {
                           v_WINDS_ID = "beb12c41-6d95-4149-af01-f784b6736daf",
                           v_PROJECT_ID = "c521123eac544281b43072ab83eea295",
                           v_Windspeed = "4--23",
                           v_North = 23,
                           v_Northnorthwest = 23,
                           v_Northwest = 23,
                           v_Westnorthwest = 23,
                           v_West = 23,
                           v_Westsouthwest = 23,
                           v_Southwest = 23,
                           v_Southsouthwest = 23,
                           v_South = 23,
                           v_Southsoutheast = 23,
                           v_Southeast = 23,
                           v_Eastsoutheast = 23,
                           v_East = 23,
                           v_Eastnortheast = 23,
                           v_Northeast = 23,
                           v_Northnortheast = 23,
                           v_None = 23
                       });

           int count = connection.Execute("InsertUpdateWIND", param: p, commandType: CommandType.StoredProcedure);

           Console.WriteLine(count);
       }
         
       public void UpdateWIND()
       {
           var p =
               new DynamicParameters(
                   new
                       {
                           v_WINDS_ID = "95e38ba9-1c9b-4f53-9ed0-322d8a259d62",
                           v_PROJECT_ID = "c521123eac544281b43072ab83eea295",
                           v_Windspeed = "2--23",
                           v_North = 23,
                           v_Northnorthwest = 23,
                           v_Northwest = 23,
                           v_Westnorthwest = 23,
                           v_West = 23,
                           v_Westsouthwest = 23,
                           v_Southwest = 23,
                           v_Southsouthwest = 23,
                           v_South = 23,
                           v_Southsoutheast = 23,
                           v_Southeast = 23,
                           v_Eastsoutheast = 23,
                           v_East = 23,
                           v_Eastnortheast = 23,
                           v_Northeast = 23,
                           v_Northnortheast = 23,
                           v_None = 23
                       });

           int count = connection.Execute("UpdateWIND", param: p, commandType: CommandType.StoredProcedure);

           Console.WriteLine(count);
       }


       public void InsertWIND()
       {
           var p =
               new DynamicParameters(
                   new
                       {
                           v_WINDS_ID = Guid.NewGuid().ToString(),
                           v_PROJECT_ID = "c521123eac544281b43072ab83eea295",
                           v_Windspeed = "1--23",
                           v_North = 22,
                           v_Northnorthwest = 22,
                           v_Northwest = 22,
                           v_Westnorthwest = 22,
                           v_West = 22,
                           v_Westsouthwest = 22,
                           v_Southwest = 22,
                           v_Southsouthwest = 22,
                           v_South = 22,
                           v_Southsoutheast = 22,
                           v_Southeast = 22,
                           v_Eastsoutheast = 22,
                           v_East = 22,
                           v_Eastnortheast = 22,
                           v_Northeast = 22,
                           v_Northnortheast = 22,
                           v_None = 22
                       });

           int count = connection.Execute("InsertWIND", param: p, commandType: CommandType.StoredProcedure);

           Console.WriteLine(count);
       }


       public void SelectWINDsAll()
       {
           var p = new OracleDynamicParameters();
           p.Add("p_cursor", dbType: OracleType.Cursor, direction: ParameterDirection.Output);

           var multi =
               connection.Query<Winds>("SelectWINDsAll", param: p, commandType: CommandType.StoredProcedure).First();

           Console.WriteLine(multi.Winds_Id);
       }



       public void SqlText()
       {
           string sql = "select * from Winds";

           IEnumerable<Winds> lstResult = connection.Query<Winds>(sql, commandType: CommandType.Text);

           foreach (var windse in lstResult)
           {
               Console.WriteLine(windse.Winds_Id);
           }

           Console.ReadKey();
       }

   */
    }

    public class Winds
    {

        private string _windsId;

        public string Winds_Id
        {
            get { return _windsId; }
            set { _windsId = value; }
        }

        private string _projectId;

        public string Project_Id
        {
            get { return _projectId; }
            set { _projectId = value; }
        }

        private string _windspeed;

        public string Windspeed
        {
            get { return _windspeed; }
            set { _windspeed = value; }
        }

        private decimal _north;

        public decimal North
        {
            get { return _north; }
            set { _north = value; }
        }

        private decimal _northnorthwest;

        public decimal Northnorthwest
        {
            get { return _northnorthwest; }
            set { _northnorthwest = value; }
        }

        private decimal _northwest;

        public decimal Northwest
        {
            get { return _northwest; }
            set { _northwest = value; }
        }

        private decimal _westnorthwest;

        public decimal Westnorthwest
        {
            get { return _westnorthwest; }
            set { _westnorthwest = value; }
        }

        private decimal _west;

        public decimal West
        {
            get { return _west; }
            set { _west = value; }
        }

        private decimal _westsouthwest;

        public decimal Westsouthwest
        {
            get { return _westsouthwest; }
            set { _westsouthwest = value; }
        }

        private decimal _southwest;

        public decimal Southwest
        {
            get { return _southwest; }
            set { _southwest = value; }
        }

        private decimal _southsouthwest;

        public decimal Southsouthwest
        {
            get { return _southsouthwest; }
            set { _southsouthwest = value; }
        }

        private decimal _south;

        public decimal South
        {
            get { return _south; }
            set { _south = value; }
        }

        private decimal _southsoutheast;

        public decimal Southsoutheast
        {
            get { return _southsoutheast; }
            set { _southsoutheast = value; }
        }

        private decimal _southeast;

        public decimal Southeast
        {
            get { return _southeast; }
            set { _southeast = value; }
        }

        private decimal _eastsoutheast;

        public decimal Eastsoutheast
        {
            get { return _eastsoutheast; }
            set { _eastsoutheast = value; }
        }

        private decimal _east;

        public decimal East
        {
            get { return _east; }
            set { _east = value; }
        }

        private decimal _eastnortheast;

        public decimal Eastnortheast
        {
            get { return _eastnortheast; }
            set { _eastnortheast = value; }
        }

        private decimal _northeast;

        public decimal Northeast
        {
            get { return _northeast; }
            set { _northeast = value; }
        }

        private decimal _northnortheast;

        public decimal Northnortheast
        {
            get { return _northnortheast; }
            set { _northnortheast = value; }
        }

        private decimal _none;

        public decimal None
        {
            get { return _none; }
            set { _none = value; }
        }

    }
     
    public class OracleDynamicParameters : Dapper.SqlMapper.IDynamicParameters
    {
        private static Dictionary<Dapper.SqlMapper.Identity, Action<IDbCommand, object>> paramReaderCache =
            new Dictionary<Dapper.SqlMapper.Identity, Action<IDbCommand, object>>();

        private Dictionary<string, ParamInfo> parameters = new Dictionary<string, ParamInfo>();
        private List<object> templates;

        private class ParamInfo
        {

            public string Name { get; set; }

            public object Value { get; set; }

            public ParameterDirection ParameterDirection { get; set; }

            public OracleType? DbType { get; set; }

            public int? Size { get; set; }

            public IDbDataParameter AttachedParam { get; set; }
        }

        /// <summary>
        /// construct a dynamic parameter bag
        /// </summary>
        public OracleDynamicParameters()
        {
        }

        /// <summary>
        /// construct a dynamic parameter bag
        /// </summary>
        /// <param name="template">can be an anonymous type or a DynamicParameters bag</param>
        public OracleDynamicParameters(object template)
        {
            AddDynamicParams(template);
        }

        /// <summary>
        /// Append a whole object full of params to the dynamic
        /// EG: AddDynamicParams(new {A = 1, B = 2}) // will add property A and B to the dynamic
        /// </summary>
        /// <param name="param"></param>
        public void AddDynamicParams(
#if CSHARP30
            object param
#else
            dynamic param
#endif
            )
        {
            var obj = param as object;
            if (obj != null)
            {
                var subDynamic = obj as OracleDynamicParameters;
                if (subDynamic == null)
                {
                    var dictionary = obj as IEnumerable<KeyValuePair<string, object>>;
                    if (dictionary == null)
                    {
                        templates = templates ?? new List<object>();
                        templates.Add(obj);
                    }
                    else
                    {
                        foreach (var kvp in dictionary)
                        {
#if CSHARP30
                            Add(kvp.Key, kvp.Value, null, null, null);
#else
                            Add(kvp.Key, kvp.Value);
#endif
                        }
                    }
                }
                else
                {
                    if (subDynamic.parameters != null)
                    {
                        foreach (var kvp in subDynamic.parameters)
                        {
                            parameters.Add(kvp.Key, kvp.Value);
                        }
                    }

                    if (subDynamic.templates != null)
                    {
                        templates = templates ?? new List<object>();
                        foreach (var t in subDynamic.templates)
                        {
                            templates.Add(t);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Add a parameter to this dynamic parameter list
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="dbType"></param>
        /// <param name="direction"></param>
        /// <param name="size"></param>
        public void Add(
#if CSHARP30
            string name, object value, DbType? dbType, ParameterDirection? direction, int? size
#else
string name, object value = null, OracleType? dbType = null, ParameterDirection? direction = null,
            int? size = null
#endif
            )
        {
            parameters[Clean(name)] = new ParamInfo()
                                          {
                                              Name = name,
                                              Value = value,
                                              ParameterDirection = direction ?? ParameterDirection.Input,
                                              DbType = dbType,
                                              Size = size
                                          };
        }

        private static string Clean(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                switch (name[0])
                {
                    case '@':
                    case ':':
                    case '?':
                        return name.Substring(1);
                }
            }
            return name;
        }

        void Dapper.SqlMapper.IDynamicParameters.AddParameters(IDbCommand command, Dapper.SqlMapper.Identity identity)
        {
            AddParameters(command, identity);
        }

        /// <summary>
        /// Add all the parameters needed to the command just before it executes
        /// </summary>
        /// <param name="command">The raw command prior to execution</param>
        /// <param name="identity">Information about the query</param>
        protected void AddParameters(IDbCommand command, Dapper.SqlMapper.Identity identity)
        {
            if (templates != null)
            {
                foreach (var template in templates)
                {
                    var newIdent = identity.ForDynamicParameters(template.GetType());
                    Action<IDbCommand, object> appender;

                    lock (paramReaderCache)
                    {
                        if (!paramReaderCache.TryGetValue(newIdent, out appender))
                        {
                            appender = Dapper.SqlMapper.CreateParamInfoGenerator(newIdent);
                            paramReaderCache[newIdent] = appender;
                        }
                    }

                    appender(command, template);
                }
            }

            foreach (var param in parameters.Values)
            {
                string name = Clean(param.Name);
                bool add = !((OracleCommand) command).Parameters.Contains(name);
                OracleParameter p;
                if (add)
                {
                    p = ((OracleCommand) command).CreateParameter();
                    p.ParameterName = name;
                }
                else
                {
                    p = ((OracleCommand) command).Parameters[name];
                }
                var val = param.Value;
                p.Value = val ?? DBNull.Value;
                p.Direction = param.ParameterDirection;
                var s = val as string;
                if (s != null)
                {
                    if (s.Length <= 4000)
                    {
                        p.Size = 4000;
                    }
                }
                if (param.Size != null)
                {
                    p.Size = param.Size.Value;
                }
                if (param.DbType != null)
                {
                    p.OracleType = param.DbType.Value;
                }
                if (add)
                {
                    command.Parameters.Add(p);
                }
                param.AttachedParam = p;
            }
        }

        /// <summary>
        /// All the names of the param in the bag, use Get to yank them out
        /// </summary>
        public IEnumerable<string> ParameterNames
        {
            get { return parameters.Select(p => p.Key); }
        }

        /// <summary>
        /// Get the value of a parameter
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="name"></param>
        /// <returns>The value, note DBNull.Value is not returned, instead the value is returned as null</returns>
        public T Get<T>(string name)
        {
            var val = parameters[Clean(name)].AttachedParam.Value;
            if (val == DBNull.Value)
            {
                if (default(T) != null)
                {
                    throw new ApplicationException("Attempting to cast a DBNull to a non nullable type!");
                }
                return default(T);
            }
            return (T) val;
        }
    }
}
