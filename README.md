//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//                                                                                                                                                                  //
//                                                                                                                                                                  //
//                     ██████╗  █████╗ ████████╗    ███╗   ███╗███████╗███╗   ██╗██╗   ██╗    ██╗████████╗███████╗███╗   ███╗███████╗ 1.3                           //
//                     ██╔══██╗██╔══██╗╚══██╔══╝    ████╗ ████║██╔════╝████╗  ██║██║   ██║    ██║╚══██╔══╝██╔════╝████╗ ████║██╔════╝                               //
//                     ██║  ██║███████║   ██║       ██╔████╔██║█████╗  ██╔██╗ ██║██║   ██║    ██║   ██║   █████╗  ██╔████╔██║███████╗                               //
//                     ██║  ██║██╔══██║   ██║       ██║╚██╔╝██║██╔══╝  ██║╚██╗██║██║   ██║    ██║   ██║   ██╔══╝  ██║╚██╔╝██║╚════██║                               //
//                     ██████╔╝██║  ██║   ██║       ██║ ╚═╝ ██║███████╗██║ ╚████║╚██████╔╝    ██║   ██║   ███████╗██║ ╚═╝ ██║███████║                               //
//                     ╚═════╝ ╚═╝  ╚═╝   ╚═╝       ╚═╝     ╚═╝╚══════╝╚═╝  ╚═══╝ ╚═════╝     ╚═╝   ╚═╝   ╚══════╝╚═╝     ╚═╝╚══════╝ by Sioum                      //
//                                                                                                                                                                  //
//                                                                                                                                                                  //
//   ___                _   __  __                                                                                                                                  //
//  | _ \ ___  __ _  __| | |  \/  | ___                                                                                                                             //
//  |   // -_)/ _` |/ _` | | |\/| |/ -_)                                                                                                                            //
//  |_|_\\___|\__,_|\__,_| |_|  |_|\___|                                                                                                                            //
//                                                                                                                                                                  //
//  Ce que fait ce script:                                                                                                                                          //
//                                                                                                                                                                  //
//  - bloquer le retour arrière en mode play.                                                                                                                       //
//  - dé-sélectionner(ctrl + q)                                                                                                                                     //
//  - effacer la console(ctrl + x)                                                                                                                                  //
//  - lancer le mode jeu(F5)                                                                                                                                        //
//  - mettre en pause(F6)                                                                                                                                           //
//  - mode pas à pas(F7)                                                                                                                                            //
//  - effacer les PlayerPrefs(ctrl + w)                                                                                                                             //
//  - ouvrir rapidement une scène(F1 /F2 /F3 /F4 /Shift+F1 /Shift+F2 /Shift+F3 /Shift+F4) (propose de sauvegarder si ce n'est pas fait)                             //
//  - sauvegarde auto des scènes (Ctrl  + <)                                                                                                                        //
//                                                                                                                                                                  //
//  Nouveauté:                                                                                                                                                      //
//                                                                                                                                                                  //
//  - copier le path de n'importe quel objet sélectionner dans la scène(ctrl + shift + C)                                                                           //
//                                                                                                                                                                  //
//  Infos pratiques:                                                                                                                                                //
//                                                                                                                                                                  //
//  Voici quelques menu items pour Unity, vous n'avez qu'à glisser ce script dans votre dossier Assets.                                                             //
//  Vous pouvez changer / ajouter des raccourcis en changeant la fin du nom du menu item en question: "%" = "ctrl" | "#" = "shift" | "&" = "alt".                   //
//  Vous pouvez aussi changer le nom des menu item destinées aux scènes pour mieux vous y retrouver.                                                                //
//  L'erreur (ArgumentException: Scene file not found: '') signifie que la scène demandé n'existe pas, cela dépend du nombre de scène que vous possédé.             //
//  Si il n'y pas assez de menu items dédiés aux scènes, il vous suffit de copier/coller le dernier et d'incrémenter le n° de la scène pour                         //
//  les 3 paramètres suivants: nom du menu item, nom de la fonction et n° de l'index. Si vous avez des améliorations à faire n'hésitez pas à m'en faire part.       //
//                                                                                                                                                                  //
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////