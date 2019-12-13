using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TshirtApp
{
  
        public class DATABASEs
        {
            readonly SQLiteAsyncConnection DATABASE;

            public DATABASEs(string dbPath)
            {
                DATABASE = new SQLiteAsyncConnection(dbPath);
                DATABASE.CreateTableAsync<REDBAT>().Wait();
            }

            public Task<List<REDBAT>> GetItemsAsync()
            {
                return DATABASE.Table<REDBAT>().ToListAsync();
            }

            public Task<List<REDBAT>> GetItemsNotDoneAsync()
            {
                return DATABASE.QueryAsync<REDBAT>("SELECT * FROM [TShirtDatabase] WHERE [Done] = 0");
            }

            public Task<REDBAT> GetItemAsync(int id)
            {
                return DATABASE.Table<REDBAT>().Where(i => i.ID == id).FirstOrDefaultAsync();
            }

            public Task<int> SaveItemAsync(REDBAT item)
            {
                if (item.ID != 0)
                {
                    return DATABASE.UpdateAsync(item);
                }
                else
                {
                    return DATABASE.InsertAsync(item);
                }
            }

            public Task<int> DeleteItemAsync(REDBAT item)
            {
                return DATABASE.DeleteAsync(item);
            }
        }
    
















}

