﻿using MemberSys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicSys
{
    public class CEmpCouponViewModel : ICRUD
    {
        private tCoupon _coupon;
        private DataGridView dataGridView;
        private CCouponModel _couponModel = new CCouponModel();
        private List<int> _couponIds = new List<int>();
        private List<CEmpCouponViewModel> _couponViewModels = new List<CEmpCouponViewModel>();

        public CEmpCouponViewModel(tCoupon coupon)
        {
           this. _coupon = coupon;
        }

        public CEmpCouponViewModel() { }

        public byte[] 優惠券照片 { get { return _coupon.fPicture; }  }
        public string 優惠券名稱 { get { return _coupon.fName; } }
        public string 優惠券種類 { get { return _coupon.fCategory; }  }
        public string 優惠值 { get { return _coupon.fValue.ToString(); } }
        public string 需滿額值 { get { return _coupon.fCriteria.ToString(); }  }
        public string 生效日期 { get { return _coupon.fStartDate.ToString("yyyy/MM/dd"); } }
        public string 失效日期 { get { return _coupon.fEndDate.ToString("yyyy/MM/dd"); } }
        public string 使用描述 { get { return _coupon.fDescription; }  }

        public void ShowAll()
        {
            reloadCouponViewModels();
            resetDateGridView();
        }

        public void Create()
        {
            _couponModel.create();
            ShowAll();
        }

        public void Delete()
        {
            int couponId = _couponIds[dataGridView.CurrentRow.Index];
            _couponModel.deletebyCouponId(couponId);
            ShowAll();
        }

        public void Update()
        {
            int currentCouponId = _couponIds[dataGridView.CurrentRow.Index];
            _couponModel.updatebyCouponId(currentCouponId);
            ShowAll();
        }

        public void Search(string keyword)
        {
            reloadCouponViewModelsbyKeyword(keyword);
            resetDateGridView();
        }

        public void reloadCouponViewModels()
        {
            _couponViewModels.Clear();
            _couponIds.Clear();
            List<tCoupon> coupons = _couponModel.getCoupons();
            coupons.ForEach(c => { _couponViewModels.Add(new CEmpCouponViewModel(c)); _couponIds.Add(c.Id); });
        }

        private void reloadCouponViewModelsbyKeyword(string keyword)
        {
            _couponViewModels.Clear();
            _couponIds.Clear();
            List<tCoupon> coupons = _couponModel.getCouponsbyKeyword(keyword);
            coupons.ForEach(c => { _couponViewModels.Add(new CEmpCouponViewModel(c)); _couponIds.Add(c.Id); });
        }

        public void mountDateGridView(DataGridView grd)
        {
            dataGridView = grd;
            ShowAll();
        }

        public void resetDateGridView()
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = _couponViewModels;
        }   
    }
}
