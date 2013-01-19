using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test
{
    public class StWebResponseLogon
    {
        int m_nHandle;                      //HTTP转换服务器句柄
        long m_nAccId;                      //外部id
        long m_nUserId;			            // 用户id
        char m_szUserName;		            //用户名
        int m_nMemberLevel;                 //会员等级
        Int64 m_nGameMoney;                 //金币
        Int64 m_nBankMoney;                 //金豆
        Int64 m_nYHCoin;                    //远航币
        Int64 m_nRiceCount;                 //财富值
        int m_nBankPosCount;                //百宝箱格数
        long m_nLogId;                      //头像ID
        bool m_bSex;	                    //性别
        int m_nGrowthPoint;                 //成长点
        int m_nTodayGrowthPoint;            //今日成长点
        DateTime m_tmMemberOverDate;        //会员过期时间
    }
}
