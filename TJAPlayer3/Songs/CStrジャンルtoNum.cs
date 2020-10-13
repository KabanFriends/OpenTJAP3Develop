namespace TJAPlayer3
{
<<<<<<< HEAD
    internal static class CStrジャンルtoNum
    {
        internal static int ForAC8_14( string strジャンル )
        {
            switch( strジャンル )
            {
                case "アニメ":
                    return 0;
                case "ポップス":
                    return 1;
                case "ゲームミュージック":
                    return 2;
                case "ナムコオリジナル":
                    return 3;
                case "クラシック":
                    return 4;
                case "キッズ":
                    return 5;
                case "ボーカロイド":
                case "VOCALOID":
=======
    public static class CStrジャンルtoNum
    {
        public static int ForAC8_14SortOrder( string strジャンル )
        {
            switch( strジャンル )
            {
                case CStrジャンル.アニメ:
                    return 0;
                case CStrジャンル.JPOP:
                    return 1;
                case CStrジャンル.ゲームミュージック:
                    return 2;
                case CStrジャンル.ナムコオリジナル:
                    return 3;
                case CStrジャンル.クラシック:
                    return 4;
                case CStrジャンル.どうよう:
                    return 5;
                case CStrジャンル.バラエティ:
                    return 6;
                case CStrジャンル.ボーカロイドJP:
                case CStrジャンル.ボーカロイドEN:
>>>>>>> twopointzero/develop
                    return 7;
                default:
                    return 8;
            }
        }

<<<<<<< HEAD
        internal static int ForAC15(string strジャンル)
        {
            switch (strジャンル)
            {
                case "ポップス":
                    return 0;
                case "アニメ":
                    return 1;
                case "ボーカロイド":
                case "VOCALOID":
                    return 2;
                case "キッズ":
                    return 3;
                case "クラシック":
                    return 5;
                case "ゲームミュージック":
                    return 6;
                case "ナムコオリジナル":
                    return 7;
                default:
                    return 8;
            }
        }
=======
        public static EジャンルAC15SortOrder ForAC15SortOrder( string strジャンル )
        {
            switch ( strジャンル )
            {
                case CStrジャンル.JPOP:
                    return EジャンルAC15SortOrder.JPOP;
                case CStrジャンル.アニメ:
                    return EジャンルAC15SortOrder.アニメ;
                case CStrジャンル.ボーカロイドJP:
                case CStrジャンル.ボーカロイドEN:
                    return EジャンルAC15SortOrder.ボーカロイド;
                case CStrジャンル.どうよう:
                    return EジャンルAC15SortOrder.どうよう;
                case CStrジャンル.バラエティ:
                    return EジャンルAC15SortOrder.バラエティ;
                case CStrジャンル.クラシック:
                    return EジャンルAC15SortOrder.クラシック;
                case CStrジャンル.ゲームミュージック:
                    return EジャンルAC15SortOrder.ゲームミュージック;
                case CStrジャンル.ナムコオリジナル:
                    return EジャンルAC15SortOrder.ナムコオリジナル;
                default:
                    return EジャンルAC15SortOrder.Unknown;
            }
        }

        public static int ForBarGenreIndex( string strジャンル )
        {
            return ForGenreBackIndex( strジャンル );
        }

        public static int ForFrameBoxIndex( string strジャンル )
        {
            return ForGenreBackIndex( strジャンル );
        }

        public static int ForGenreBackIndex( string strジャンル )
        {
            switch ( strジャンル )
            {
                case CStrジャンル.JPOP:
                    return 1;
                case CStrジャンル.アニメ:
                    return 2;
                case CStrジャンル.ゲームミュージック:
                    return 3;
                case CStrジャンル.ナムコオリジナル:
                    return 4;
                case CStrジャンル.クラシック:
                    return 5;
                case CStrジャンル.バラエティ:
                    return 6;
                case CStrジャンル.どうよう:
                    return 7;
                case CStrジャンル.ボーカロイドJP:
                case CStrジャンル.ボーカロイドEN:
                    return 8;
                default:
                    return 0;
            }
        }

        public static int ForGenreTextIndex( string strジャンル )
        {
            return ForAC8_14SortOrder( strジャンル );
        }
>>>>>>> twopointzero/develop
    }
}