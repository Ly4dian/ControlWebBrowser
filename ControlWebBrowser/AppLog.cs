using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlWebBrowser
{
    /// <summary>
    /// アプリケーション独自デバッグ用ログクラス
    /// </summary>
    class AppLog
    {
        private static System.IO.StreamWriter _sw = null;

        /// <summary>
        /// ファイル書き出しを開始
        /// </summary>
        public static void Start()
        {
            AppLog._sw = new System.IO.StreamWriter(
                    System.IO.Path.GetDirectoryName(
                    System.Reflection.Assembly.GetExecutingAssembly().Location) +
                    System.IO.Path.DirectorySeparatorChar + "App.log", true);
        }

        /// <summary>
        /// ファイル書き出しを終了
        /// </summary>
        public static void Close()
        {
            AppLog._sw.Close();
        }

        /// <summary>
        /// 書き込み
        /// </summary>
        /// <param name="value">書き込む値</param>
        public static void WriteLine(object value)
        {
            // TODO もしだったら、型を調べて配列やリストの展開を行ったり
            _sw.WriteLine(value);
        }
    }
}