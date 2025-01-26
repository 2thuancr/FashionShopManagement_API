using DAO;
using DTO.Accounts;
using System;
using System.Collections.Generic;
using System.Data;

namespace BUS
{
    public class AccountTypePermissionBUS
    {
        private static AccountTypePermissionBUS instance;

        public static AccountTypePermissionBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new AccountTypePermissionBUS();
                return AccountTypePermissionBUS.instance;
            }
        }

        public List<AccountTypePermissionDetail> GetPermissionByAccountTypeId(int accountTypeId)
        {
            DataTable table;
            try
            {
                table = AccountTypePermissionDAO.Instance.GetPermissionByAccountTypeId(accountTypeId);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            List<AccountTypePermissionDetail> listPermission = new List<AccountTypePermissionDetail>();
            foreach (DataRow row in table.Rows)
            {
                AccountTypePermissionDetail accountTypePermissionDetail = new AccountTypePermissionDetail(row);
                listPermission.Add(accountTypePermissionDetail);
            }
            return listPermission;
        }

        /// <summary>
        /// Kiểm tra xem AccountTypeId có quyền tên là PermissionName hay không
        /// </summary>
        /// <param name="accountTypeId"></param>
        /// <param name="permissionName"></param>
        /// <returns></returns>
        public bool CheckPermissionByAccountTypeId(int accountTypeId, string permissionName)
        {
            // lấy tất cả các quyền của AccountTypeId
            List<AccountTypePermissionDetail> listPermissions = GetPermissionByAccountTypeId(accountTypeId);

            // kiểm tra xem là listPermissions này có chứa permissionName đang check không
            if (listPermissions.Count == 0)
            {
                return false;
            }
            else
            {
                int index = listPermissions.FindIndex(x => x.PermissionName == permissionName);
                return index != -1;
            }
        }
    }
}
