using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LukeFrahm.Mobile.CognizantSelf.Shared.Models;

namespace LukeFrahm.Mobile.CognizantSelf.Shared.Services
{
    public interface IDataService<T> where T : IStorableModel
    {
        Task<bool> AddItemAsync(T item);
        Task<bool> UpdateItemAsync(T item);
        Task<bool> DeleteItemAsync(string id);
        Task<T> GetItemAsync(string id);
        Task<IEnumerable<T>> GetItemsAsync(bool forceRefresh = false);
    }
}
