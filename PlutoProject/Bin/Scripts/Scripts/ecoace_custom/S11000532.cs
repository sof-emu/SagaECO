﻿using System;
using System.Collections.Generic;
using System.Text;
using SagaLib;
using SagaDB;
using SagaDB.Item;
using SagaDB.Actor;
using SagaMap.Network.Client;
using SagaMap.Scripting;
using SagaMap.Manager;
using SagaScript.Chinese.Enums;
namespace SagaScript
{
    public class S11000532 : Event
    {
        public S11000532()
        {
            this.EventID =11000532;
        }
        public MapClient client;
        //event start
        public override void OnEvent(ActorPC pc)
        {
            Say(pc, 11000532, 131, "最近阿克罗波利斯发生了"+
                                   "一些事情,想不想听一听?$R;", "初心者向导");
            switch (Select(pc, "想听什么话题?", "", "理发师尼博隆根", "得菩提","伊濑黑绘","莎莉耶","其他","没兴趣"))
            {
                case 1:
                    Say(pc, 11000532, 131, "尼博隆根那个死话唠?$R;" +
                                           "...他好像是理发的时候$R;" +
                                           "得罪了一个小姑娘...$R", "初心者向导");
                    Say(pc, 11000532, 131, "结果被暴打了一顿$R" +
                                           "不止自己被赶走,到现在还下落不明$R;"+
                                           "连店铺都被小姑娘霸占了$R;", "初心者向导");
                    Say(pc, 11000532, 131, "不过说来有意思呢……$R;" +
                                           "那个小姑娘做发型，好像比尼博隆根$R;"+
                                           "靠谱多了..$R;", "初心者向导");
                    if (pc.Gender == PC_GENDER.MALE)
                    {
                        Say(pc, 11000532, 131, "当然...$R;"+
                                               "如果是你的话..还是别去为好,听我的", "初心者向导");
                    }
                    break;
                case 2:
                    //Say(pc, 11000532, 131, "那个三流公司的业务员?$R;" +
                    //                       "他们公司的老板欠工资三个月$R;" +
                    //                       "辛辛苦苦干了几年就这个下场...真是$R", "初心者向导");
                    //Say(pc, 11000532, 131, "总之..他们公司倒闭了$R" +
                    //                       "他也不知道去哪了,哎,真是令人同情$R" +
                    //                       "当然了,如果你还需要兑换什么东西$R;" +
                    //                       "在大陆洞窟和沃特雷亚冒险了好几年$R;" +
                    //                       "的一个出名的冒险者现在也提供兑换$R;" , "初心者向导");
                    //Say(pc, 11000532, 131, "当然..动机是个谜,她“遥远的绿巨人”$R;" +
                    //                       "这个“名字”似乎也只是个外号$R;" +
                    //                       "那么...她到底是谁呢?$R;", "初心者向导"); 
                    Say(pc, 11000532, 131, "……你说那个骗钱公司的业务员啊?$R;" +
                                           "老板欠工资跑路啦。$R;" +
                                           "说起那位也是可怜，辛勤干了这么多年，却沦落到这地步。$R", "初心者向导");
                    Say(pc, 11000532, 131, "总之，那个公司早就不存在了。$R" +
                                           "那位业务员，现在也不知道去了哪里……$R" +
                                           "啊啊，算了，别管他了，如果你还想换其他新鲜物件儿的话，$R;" +
                                           "就去找那个经常在大陆洞窟和沃特雷亚泡着的，$R;" +
                                           "那位有名的冒险者吧。$R;", "初心者向导");
                    Say(pc, 11000532, 131, "虽然到现在也没人知道她为什么做起兑换物品这种事儿，$R;" +
                                           "甚至，那个“遥远的绿巨人”的称呼是不是本名都很可疑呢。$R;" +
                                           "……她到底是什么人呢……？$R;", "初心者向导"); 
                    break;
                case 3:
                    Say(pc, 11000532, 131, "在居住区不知道什么时候?$R;" +
                                           "冒出了一个提供....叫什么来着$R;" +
                                           "看上去都是些女孩子$R;", "初心者向导");
                    Say(pc, 11000532, 131, "当时就有人打了报告$R;" +
                                           "连混成骑士团都出动了$R;" +
                                           "结果鉴定后,不是埃米尔,$R;" +
                                           "不是泰达尼亚,也不是多米尼翁,$R;" +
                                           "所以不构成贩卖人口罪$R;" +
                                           "当然,用金币也是买不到的$R;" +
                                           "那个人似乎是要圣者什么的...想不起来了$R;", "初心者向导");
                    Say(pc, 11000532, 131, "我的建议是,离她远点$R;" +
                                           "理所当然啦!就算混成骑士团不说话$R;" +
                                           "怎么看都是贩卖人口的嘛!$R;", "初心者向导");
                    break;
                case 4:
                    Say(pc, 11000532, 131, "从天而降的天使?$R;" +
                                           "太老套了$R;" +
                                           "自从泰达尼亚出现之后"+
                                           "就没什么新鲜的了$R;", "初心者向导");
                    Say(pc, 11000532, 131, "当然这个泰达尼亚有点$R;" +
                                           "特别,她是从天而降之后在$R;" +
                                           "果物之森像陨石一样砸了$R;" +
                                           "一个巨坑,混成骑士团$R;" +
                                           "赶到现场却什么都没发现$R;" +
                                           "当然事后我们都知道了,她被$R;" +
                                           "一个埃米尔人救走了,现在$R;" +
                                           "住在商业区$R;", "初心者向导");
                    Say(pc, 11000532, 131, "那么她到底是谁?$R;" +
                                           "从天而降头着地?$R;" +
                                           "我可没听说过泰达尼亚"+
                                           "是这么来我们世界的!$R;", "初心者向导");
                    break;
                case 5:
                    Say(pc, 11000532, 131, "其实也没多大的事?$R;" +
                                           "阿克罗波利斯的后备仓库里$R;" +
                                           "大批的法伊斯特入境通行证被盗$R", "初心者向导");
                    Say(pc, 11000532, 131, "为什么会这样呢?$R;" +
                                           "明明最发达的是艾恩萨乌斯$R;" +
                                           "这个小偷也太熟练了点吧!$R;", "初心者向导");
                    break;
                case 6:
                    break;
            }
            //Say(pc, 131, "有什么事情就找我!$R不要去找艾达!", "初心者向导");

        }
    }
}