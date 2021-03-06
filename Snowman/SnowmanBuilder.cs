﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Snowman
{
    class SnowmanBuilder
    {

        private string _snowMan = "";
        public string SnowMan
        {
            get { return _snowMan; }
        }

        // Switch statement builds the snowman as Player guesses incorrectly
        public void Build(int incorrectGuess)
        {            
            switch (incorrectGuess)
            {
                case 0:
                    break;
                case 1:
                    this._snowMan = @"
                                     .-''       '`-.
                                   .'               `.      *
                                  :                   :
                                 :                     :
                                 :                     :
                          *      :                     :     *
                                 :                     :
                                  :                   :
                                   `.               .'
                                     `-.________.- '


                        ";
                    break;
                case 2:
                    this._snowMan = @"
                              \~_s~-~s~s                        *
                        *      `--~-~-~~s~/` ' ' `-.  
                                    / s /           `
                                   / s /
                                  / s /              :  *
                        *        / s /              .'          *
                                   |/`.           .'
                                    .- ''---- - '`-.
                                  .'                `.      *
                                 :                    :
                                :                      :
                                :                      :
                        *       :                      :     *
                                :                      :
                                 :                    :
                                  `.               .'
                                    `-._________.-'
                        ";
                    break;
                case 3:
                    this._snowMan = @"
                                       .'       `.   *      
                                      :           :         
                                      :           :       
                             \~_s~-~s~s`._     _.'             *
                          *   `--~-~-~~s~/` ' '  `-.    
                                      /s/           `  
                                     /s/              
                                    /s/              :  *
                            *      /s/              .'          *
                                   |/`.           .'
                                     .-''-------'`-.
                                   .'               `.      *
                                  :                   :
                                 :                     :
                                 :                     :
                          *      :                     :     *
                                 :                     :
                                  :                   :
                                   `.               .'
                                     `-._________.-'
                        ";
                    break;
                case 4:
                    this._snowMan = @"
                                       .'       `.   *   
                                      :           :     
                                      :           :     
                             \~_s~-~s~s`._     _.'             *
                          *   `--~-~-~~s~/` ' '  `-.   
                                    /'/s/           `
                                   / /s/             
                                  ///s/              :  *
                            *    ///s/              .'          *
                                // |/`.           .'
                             __//    .-''-------'`-.
                              /|\  .'               `.      *
                             / | \:                   :
                                 :                     :
                                 :                     :
                          *      :                     :     *
                                 :                     :
                                  :                   :
                                   `.               .'
                                     `-._________.-'
                        ";
                    break;
                case 5:
                    this._snowMan = @"
                                       .'       `.   *   | /
                                      :           :     \|/_
                                      :           :     //
                             \~_s~-~s~s`._     _.'     //      *
                          *   `--~-~-~~s~/` ' '  `-.  //
                                    /'/s/           `//
                                   / /s/             /
                                  ///s/              :  *
                            *    ///s/              .'          *
                                // |/`.           .'
                             __//    .-''-------'`-.
                              /|\  .'               `.      *
                             / | \:                   :
                                 :                     :
                                 :                     :
                          *      :                     :     *
                                 :                     :
                                  :                   :
                                   `.               .'
                                     `-._________.-'
                        "; 
                    break;
                case 6:
                    this._snowMan = @"
                                        .-------.
                              *         | #     |    *
                                        |_______|         *
                                       _|=======|_             *
                           *          [___________]
                                       .'       `.   *   | /
                                      :           :     \|/_
                                      :           :     //
                             \~_s~-~s~s`._     _.'     //      *
                          *   `--~-~-~~s~/` ' '  `-.  //
                                    /'/s/           `//
                                   / /s/             /
                                  ///s/              :  *
                            *    ///s/              .'          *
                                // |/`.           .'
                             __//    .-''-------'`-.
                              /|\  .'               `.      *
                             / | \:                   :
                                 :                     :
                                 :                     :
                          *      :                     :     *
                                 :                     :
                                  :                   :
                                   `.               .'
                                     `-._________.-'

                        ";
                    break;
                case 7:
                    this._snowMan = @"
                                        .-------.
                              *         | #     |    *
                                        |_______|         *
                                       _|=======|_             *
                           *          [___________]
                                       .'       `.   *   | /
                                      :   @   @   :     \|/_
                                      :           :     //
                             \~_s~-~s~s`._     _.'     //      *
                          *   `--~-~-~~s~/` ' '  `-.  //
                                    /'/s/           `//
                                   / /s/             /
                                  ///s/              :  *
                            *    ///s/              .'          *
                                // |/`.           .'
                             __//    .-''-------'`-.
                              /|\  .'               `.      *
                             / | \:                   :
                                 :                     :
                                 :                     :
                          *      :                     :     *
                                 :                     :
                                  :                   :
                                   `.               .'
                                     `-._________.-'

                        ";
                    break;
                case 8:
                    this._snowMan = @"
                                        .-------.
                              *         | #     |    *
                                        |_______|         *
                                       _|=======|_             *
                           *          [___________]
                                       .'       `.   *   | /
                                      :   @   @   :     \|/_
                                      :     <     :     //
                             \~_s~-~s~s`._     _.'     //      *
                          *   `--~-~-~~s~/` ' '  `-.  //
                                    /'/s/           `//
                                   / /s/             /
                                  ///s/              :  *
                            *    ///s/              .'          *
                                // |/`.           .'
                             __//    .-''-------'`-.
                              /|\  .'               `.      *
                             / | \:                   :
                                 :                     :
                                 :                     :
                          *      :                     :     *
                                 :                     :
                                  :                   :
                                   `.               .'
                                     `-._________.-'
                        ";
                    break;
                case 9:
                    this._snowMan = @"
                                        .-------.
                              *         | #     |    *
                                        |_______|         *
                                       _|=======|_             *
                           *          [___________]
                                       .'       `.   *   | /
                                      :   @   @   :     \|/_
                                      :     <     :     //
                             \~_s~-~s~s`._`...'_.'     //      *
                          *   `--~-~-~~s~/` ' '  `-.  //
                                    /'/s/           `//
                                   / /s/             /
                                  ///s/              :  *
                            *    ///s/              .'          *
                                // |/`.           .'
                             __//    .-''-------'`-.
                              /|\  .'               `.      *
                             / | \:                   :
                                 :                     :
                                 :                     :
                          *      :                     :     *
                                 :                     :
                                  :                   :
                                   `.               .'
                                     `-._________.-'
                        ";
                    break;
                case 10:
                    this._snowMan = @"
                                        .-------.
                              *         | #     |    *
                                        |_______|         *
                                       _|=======|_             *
                           *          [___________]
                                       .'       `.   *   | /
                                      :   @   @   :     \|/_
                                      :     <     :     //
                             \~_s~-~s~s`._`...'_.'     //      *
                          *   `--~-~-~~s~/` ' '  `-.  //
                                    /'/s/   _       `//
                                   / /s/   (_)       /
                                  ///s/     _        :  *
                            *    ///s/     (_)      .'          *
                                // |/`.           .'
                             __//    .-''-------'`-.
                              /|\  .'       _       `.      *
                             / | \:        (_)        :
                                 :          _          :
                                 :         (_)         :
                          *      :          _          :     *
                                 :         (_)         :
                                  :                   :
                                   `.               .'
                                     `-._________.-'    
                        ";
                    break;
            }
        }

    }

}
