﻿using ENode.Domain;
using GPermission.Common;
using GPermission.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GPermission.Domain.Accounts
{
    /// <summary>账号管理权限
    /// </summary>
    [Serializable]
    public class Account : AggregateRoot<string>
    {
        private AccountInfo _info;
        private IList<string> _appSystems;
        private string _status;
        private int _useFlag;


        public Account(string id, AccountInfo info) : base(id)
        {
            Assert.IsNotNullOrEmpty("账号名", info.AccountName);
            Assert.IsNotNullOrEmpty("账号密码", info.AccountPassword);
            Assert.IsNotInEnum("账号类型", typeof(AccountType), info.AccountType);
            ApplyEvent(new AccountCreated(  info));
        }

        public void Change(int useFlag)
        {
            Assert.IsNotInEnum("删除标志", typeof (UseFlag), useFlag);
            ApplyEvent(new AccountChanged(useFlag));
        }



        #region Event Handle Methods
        private void Handle(AccountCreated evnt)
        {
            _id = evnt.AggregateRootId;
            _info = evnt.Info;
            _appSystems = new List<string>();
            _status = AccountStatus.Normal.ToString();
            _useFlag = (int)UseFlag.Useable;
        }

        //删除
        private void Handle(AccountChanged evnt)
        {
            _useFlag = evnt.UseFlag;
        }

        #endregion
    }
}
