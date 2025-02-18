using DAO;
using DTO.Accounts;
using DTO.Categories;
using DTO.Products;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class CategoriesBUS
    {
        private static CategoriesBUS instance;

        public static CategoriesBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new CategoriesBUS();
                return CategoriesBUS.instance;
            }
        }

        private CategoriesBUS() { }

        public List<Categories> GetAllCategories()
        {
            DataTable table = new DataTable();
            try
            {
                table = CategoriesDAO.Instance.GetAllCategories();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            List<Categories> lstCategories = new List<Categories>();
            foreach (DataRow row in table.Rows)
            {
                Categories categories = new Categories(row);
                lstCategories.Add(categories);
            }
            return lstCategories;
        }

        public List<Categories> SearchCategories(CategoriesSearchRequest request)
        {
            DataTable table = new DataTable();
            try
            {
                table = CategoriesDAO.Instance.SearchCategories(request.name);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            List<Categories> lstCategories = new List<Categories>();
            foreach (DataRow row in table.Rows)
            {
                Categories categories = new Categories(row);
                lstCategories.Add(categories);
            }
            return lstCategories;
        }

        public Categories GetCategoryById(int id)
        {
            DataTable table = new DataTable();
            try
            {
                table = CategoriesDAO.Instance.GetCategoryById(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            foreach (DataRow row in table.Rows)
            {
                Categories categories = new Categories(row);
                return categories;
            }
            return null;
        }
        public CategoriesInsertResponse InsertCategory(CategoriesInsertRequest request)
        {
            if (request.parent_id <= 0)
            {
                throw new Exception("Lỗi Parent Id không hợp lệ");
            }    
            var category = new Categories
            {
                name = request.name,
                parent_id = request.parent_id,
            };
            var isCreated = CategoriesDAO.Instance.InsertCategory(category);
            return new CategoriesInsertResponse
            {
                IsCreated = isCreated
            };
        }
    }
}
