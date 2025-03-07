﻿using DPU_Soft.BLL.Base.Interfaces;
using DPU_Soft.BLL.Functions;
using DPU_Soft.DAL.Interfaces;
using DPU_Soft.PlacementOfExams.Common.Enums;
using DPU_Soft.PlacementOfExams.Common.Functions;
using DPU_Soft.PlacementOfExams.Common.Massage;
using DPU_Soft.PlacementOfExams.Model.Attributes;
using DPU_Soft.PlacementOfExams.Model.Entities.Base;
using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace DPU_Soft.BLL.Base
{
    public class BaseBll<T,TContext>:IBaseBll where T:BaseEntity where TContext: DbContext
    {
        private readonly Control _ctrl;

        private IUnitOfWork<T> _unitOfWork;

        private bool Validation(IslemTuru islemTuru, BaseEntity oldEntity, BaseEntity currententity, Expression<Func<T, bool>> filter)
        {
            var errorControl = GetValidationErrorControl();
            if (errorControl == null) return true;
            _ctrl.Controls[errorControl].Focus();
            return false;
            string GetValidationErrorControl()
            {
                string MukerrerKod()
                {
                    foreach (var property in typeof(T).GetPropertyAttributesFromType<Kod>())
                    {
                        if (property.Attribute == null) continue;
                        if ((islemTuru == IslemTuru.EntityInsert || oldEntity.Kod == currententity.Kod) && islemTuru == IslemTuru.EntityUpdate) continue;
                        if (_unitOfWork.Rep.Count(filter) < 1) continue;

                        Messages.MukerrerKayitHataMesaj(property.Attribute.Descriptiıon);
                        return property.Attribute.ControlName;
                    }
                    return null;
                }
                string HataliGiris()
                {
                    foreach (var property in typeof(T).GetPropertyAttributesFromType<ZorunluAlan>())
                    {
                        if (property.Attribute == null) continue;
                        var value = property.Property.GetValue(currententity);
                        if (property.Property.PropertyType == typeof(long))
                            if ((long)value == 0)
                                value = null;

                        if (!string.IsNullOrEmpty(value?.ToString())) continue;
                        Messages.HataliVeriMesaj(property.Attribute.Descriptiıon);
                            

                        return property.Attribute.ControlName;
                    }
                    return null;
                }
                return HataliGiris() ?? MukerrerKod();
            }
        }

        protected BaseBll()
        {


        }

        protected BaseBll(Control ctrl)
        {
            _ctrl = ctrl;
        }

        protected TResult Basesingle<TResult>(Expression<Func<T, bool>> filter, Expression<Func<T, TResult>> selector)
        {
            GeneralFunctions.CreateUnitOfWork<T, TContext>(ref _unitOfWork);
            return _unitOfWork.Rep.Find(filter, selector);
        }

        protected IQueryable<TResult> BaseList<TResult>(Expression<Func<T, bool>> filter, Expression<Func<T, TResult>> selector)
        {
            GeneralFunctions.CreateUnitOfWork<T, TContext>(ref _unitOfWork);
            return _unitOfWork.Rep.Select(filter, selector);
        }

        protected bool BaseInsert(BaseEntity entity, Expression<Func<T,bool>>filter)
        {
            GeneralFunctions.CreateUnitOfWork<T, TContext>(ref _unitOfWork);
            if (!Validation(IslemTuru.EntityInsert, null, entity, filter)) return false;
            _unitOfWork.Rep.Insert(entity.EntityConvert<T>());
            return _unitOfWork.Save();
        }

        protected bool BaseUpdate(BaseEntity oldEntity, BaseEntity currentEntity, Expression<Func<T, bool>> filter)
        {
            GeneralFunctions.CreateUnitOfWork<T, TContext>(ref _unitOfWork);
            if (!Validation(IslemTuru.EntityUpdate, oldEntity, currentEntity, filter)) return false;
            var degisenAlanlar = oldEntity.DegisenAlanalariGetir(currentEntity);
            if (degisenAlanlar.Count == 0) return true;
            
            _unitOfWork.Rep.Update(currentEntity.EntityConvert<T>(), degisenAlanlar);
            return _unitOfWork.Save();
        }

        protected bool BaseDelete(BaseEntity entity, KartTuru kartTuru ,bool mesajVer=true)
        {
            GeneralFunctions.CreateUnitOfWork<T, TContext>(ref _unitOfWork);
            //Validation işlemleri yap

            if (mesajVer)
                if (Messages.SilMesaj(kartTuru.ToName()) != DialogResult.Yes) return false;


            _unitOfWork.Rep.Delete(entity.EntityConvert<T>());
            return _unitOfWork.Save();
        }

        protected string BaseYeniKodVer(KartTuru kartTuru, Expression<Func<T,string>> filter,Expression<Func<T,bool>>where =null)
        {
            GeneralFunctions.CreateUnitOfWork<T, TContext>(ref _unitOfWork);
            return _unitOfWork.Rep.YeniKodVer(kartTuru,filter,where);

        }

        #region IDisposable Support
 
        public void Dispose()
        {
            _ctrl?.Dispose();
            _unitOfWork?.Dispose();           

        }

        #endregion

    }
}
