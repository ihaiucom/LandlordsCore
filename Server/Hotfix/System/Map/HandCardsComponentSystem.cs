﻿using Model;

namespace Hotfix
{
    public static class HandCardsComponentSystem
    {
        public static Card[] GetAll(this HandCardsComponent self)
        {
            return self.library.ToArray();
        }

        /// <summary>
        /// 向牌库中添加牌
        /// </summary>
        /// <param name="card"></param>
        public static void AddCard(this HandCardsComponent self, Card card)
        {
            self.library.Add(card);
        }

        /// <summary>
        /// 出牌
        /// </summary>
        /// <param name="self"></param>
        /// <param name="card"></param>
        public static void PopCard(this HandCardsComponent self,Card card)
        {
            self.library.Remove(card);
        }

        /// <summary>
        /// 手牌排序
        /// </summary>
        /// <param name="self"></param>
        public static void Sort(this HandCardsComponent self)
        {
            CardsHelper.SortCards(self.library);
        }
    }
}
