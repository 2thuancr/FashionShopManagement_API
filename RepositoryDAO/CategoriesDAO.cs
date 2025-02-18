using DTO.Categories;
using DTO.Products;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class CategoriesDAO
    {
        private static CategoriesDAO instance;

        public static CategoriesDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new CategoriesDAO();
                return CategoriesDAO.instance;
            }
        }

        private CategoriesDAO() { }

        public DataTable GetAllCategories()
        {
            string query = "[dbo].[USP_GetAllCategories]";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable SearchCategories(string name) 
        {
            string query = $"[dbo].[USP_SearchCategories] @name = N'{name}'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable GetCategoryById(int id)
        {
            string query = $"[dbo].[USP_GetCategoryById] @id = {id}";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        // Thêm mới Danh muc mới 
        public bool InsertCategory(Categories newCategory)
        {
            if(newCategory.parent_id > 0)
            {
                string query = $"USP_InsertCategory @name = N'{newCategory.name}', @parent_id = {newCategory.parent_id}";
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                return result > 0;
            }    
            else
            {
                string query = $"USP_InsertCategory @name = N'{newCategory.name}'";
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                return result > 0;
            }
          
        }
        public bool UpdateCategory(Categories categories)
        {
            if(categories.parent_id > 0)
            {
                string query = $"USP_UpdateCategory " +
                $"@id = {categories.id} , " +
                $"@name = N'{categories.name}' , " +
                $"@parent_id = {categories.parent_id}";

                int result = DataProvider.Instance.ExecuteNonQuery(query);
                return result > 0;
            }    
            else
            {
                string query = $"USP_UpdateCategory " +
                $"@id = {categories.id} , " +
                $"@name = N'{categories.name}'";

                int result = DataProvider.Instance.ExecuteNonQuery(query);
                return result > 0;
            }    
        }
        public bool DeleteCategory(Categories categories)
        {
            if(categories.id > 0)
            {
                string query = $"USP_DeleteCategory @id = {categories.id}";
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                return result > 0;
            }
            else
            {
                return false;
            }    
        }
    }
}
