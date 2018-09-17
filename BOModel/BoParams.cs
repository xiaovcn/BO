using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOModel
{
    public class BoParams
    {
        /// <summary>
        /// 油饱和度
        /// </summary>
        public decimal So { get; set; }
        /// <summary>
        /// 气饱和度
        /// </summary>
        public decimal Sg { get; set; }
        /// <summary>
        /// 水饱和度
        /// </summary>
        public decimal Sw { get; set; }

        /// <summary>
        /// 油密度
        /// </summary>
        public decimal Rho_o { get; set; }
        /// <summary>
        /// 气密度
        /// </summary>
        public decimal Rho_g { get; set; }
        /// <summary>
        /// 水密度
        /// </summary>
        public decimal Rho_w { get; set; }

        /// <summary>
        /// 溶解气油比
        /// </summary>
        public decimal Rso { get; set; }

        /// <summary>
        /// 溶解气水比
        /// </summary>
        public decimal Rsw { get; set; }

        /// <summary>
        /// 油体积系数
        /// </summary>
        public decimal Bo { get; set; }
        /// <summary>
        /// 气体积系数
        /// </summary>
        public decimal Bg { get; set; }
        /// <summary>
        /// 水体积系数
        /// </summary>
        public decimal Bw { get; set; }

        /// <summary>
        /// 油相对渗透率
        /// </summary>
        public decimal Kro { get; set; }

        /// <summary>
        /// 气相对渗透率
        /// </summary>
        public decimal Krg { get; set; }

        /// <summary>
        /// 水相对渗透率
        /// </summary>
        public decimal Krw { get; set; }

        /// <summary>
        /// 油粘度
        /// </summary>
        public decimal Uo { get; set; }

        /// <summary>
        /// 气粘度
        /// </summary>
        public decimal Ug { get; set; }

        /// <summary>
        /// 水粘度
        /// </summary>
        public decimal Uw { get; set; }

        /// <summary>
        /// 油压力
        /// </summary>
        public decimal Po { get; set; }

        /// <summary>
        /// 气压力
        /// </summary>
        public decimal Pg { get; set; }

        /// <summary>
        /// 水压力
        /// </summary>
        public decimal Pw { get; set; }

        /// <summary>
        /// 地面标准条件下单位时间单位体积铲除或注入油体积
        /// </summary>
        public decimal Qvo { get; set; }
        /// <summary>
        /// 地面标准条件下单位时间单位体积铲除或注入气体积
        /// </summary>
        public decimal Qvg { get; set; }
        /// <summary>
        /// 地面标准条件下单位时间单位体积铲除或注入水体积
        /// </summary>
        public decimal Qvw { get; set; }


        /// <summary>
        /// 油水两相毛管压力
        /// </summary>
        public decimal Pcow { get { return Po - Pw; } }

        /// <summary>
        /// 气油两相毛管压力
        /// </summary>
        public decimal Pcgo { get { return Pg - Po; } }


    }
}
