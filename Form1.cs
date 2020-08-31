using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using IniParser;
using IniParser.Model;
using System.Runtime.CompilerServices;

namespace YIIK_Save_Editor
{
    public partial class Form1 : Form
    {
        struct InventoryItem
        {
            public InventoryItem(string name, int count)
            {
                Name = name;
                Count = count;
            }
            public string Name;
            public int Count;
        }

        List<InventoryItem> items;

        IniData save;
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage9_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "YIIK Save INIs|*.txt";
            open.CheckFileExists = true;
            if (open.ShowDialog() == DialogResult.OK)
            {
                //do stuff here, open.FileName is the full path of the selected file
                save = new FileIniDataParser().ReadFile(open.FileName);
                loadSaveData();
            }
        }

        public void saveSaveData()
        {
            switch (SeasonTime.SelectedIndex)
            {
                case 0:
                    save["WhatTimeIsIt"]["SeasonAndTimeOfDayTexture"] = "2";
                    save["WhatTimeIsIt"]["TimeOfDay"] = "-1";
                    save["WhatSeasonIsIt"]["Season"] = "0";
                    break;
                case 1:
                    save["WhatTimeIsIt"]["SeasonAndTimeOfDayTexture"] = "1";
                    save["WhatTimeIsIt"]["TimeOfDay"] = "3";
                    save["WhatSeasonIsIt"]["Season"] = "0";
                    break;
                case 2:
                    save["WhatTimeIsIt"]["SeasonAndTimeOfDayTexture"] = "4";
                    save["WhatTimeIsIt"]["TimeOfDay"] = "-1";
                    save["WhatSeasonIsIt"]["Season"] = "3";
                    break;
                case 3:
                    save["WhatTimeIsIt"]["SeasonAndTimeOfDayTexture"] = "5";
                    save["WhatTimeIsIt"]["TimeOfDay"] = "3";
                    save["WhatSeasonIsIt"]["Season"] = "3";
                    break;
                case 4:
                    save["WhatTimeIsIt"]["SeasonAndTimeOfDayTexture"] = "6";
                    save["WhatTimeIsIt"]["TimeOfDay"] = "-1";
                    save["WhatSeasonIsIt"]["Season"] = "4";
                    break;
                case 5:
                    save["WhatTimeIsIt"]["SeasonAndTimeOfDayTexture"] = "7";
                    save["WhatTimeIsIt"]["TimeOfDay"] = "3";
                    save["WhatSeasonIsIt"]["Season"] = "4";
                    break;
                default:
                    save["WhatTimeIsIt"]["SeasonAndTimeOfDayTexture"] = "2";
                    save["WhatTimeIsIt"]["TimeOfDay"] = "-1";
                    save["WhatSeasonIsIt"]["Season"] = "0";
                    break;
            }
            save["SaveEditor"]["eco asked me to put a line in here that proves it's been edited by the save editor"] = "blame eco";
            save["Alex"]["level"] = AlexLevel.Value.ToString();
            save["Alex"]["hp"] = AlexHP.Value.ToString();
            save["Alex"]["maxHP"] = AlexMHP.Value.ToString();
            save["Alex"]["pp"] = AlexPP.Value.ToString();
            save["Alex"]["maxPP"] = AlexMPP.Value.ToString();
            save["Alex"]["str"] = AlexSTR.Value.ToString();
            save["Alex"]["def"] = AlexDEF.Value.ToString();
            save["Alex"]["speed"] = AlexAGI.Value.ToString();
            save["Alex"]["luck"] = AlexLUK.Value.ToString();
            save["Alex.Equipment.Attatched"]["WEAPON"] = AlexWeapon.Text;
            save["Alex.Equipment.Attatched"]["BODY"] = AlexBody.Text;
            save["Alex.Equipment.Attatched"]["HEAD"] = AlexHead.Text;
            save["Alex.Equipment.Attatched"]["OTHER"] = AlexOther.Text;
            save["Alex.Equipment.Attatched"]["CLOTHES"] = AlexBody.Text;
            save["Alex.Equipment.Attatched"]["HAT"] = AlexHead.Text;
            save["Alex.Skills.Attatched"]["Panda Barrier"] = Convert.ToString(Convert.ToInt32(AlexSPandaBarrier.Checked));
            save["Alex.Skills.Attatched"]["Smooth Jazz"] = Convert.ToString(Convert.ToInt32(AlexSSmoothJazz.Checked));
            save["Alex.Skills.Attatched"]["LP Toss"] = Convert.ToString(Convert.ToInt32(AlexSLPToss.Checked));
            save["Alex.Skills.Attatched"]["EP Strike"] = Convert.ToString(Convert.ToInt32(AlexSEPStrike.Checked));
            save["Alex"]["currentXp"] = AlexEXP.Value.ToString();
            save["Michael"]["level"] = MichaelLevel.Value.ToString();
            save["Michael"]["hp"] = MichaelHP.Value.ToString();
            save["Michael"]["maxHP"] = MichaelMHP.Value.ToString();
            save["Michael"]["pp"] = MichaelPP.Value.ToString();
            save["Michael"]["maxPP"] = MichaelMPP.Value.ToString();
            save["Michael"]["str"] = MichaelSTR.Value.ToString();
            save["Michael"]["def"] = MichaelDEF.Value.ToString();
            save["Michael"]["speed"] = MichaelAGI.Value.ToString();
            save["Michael"]["luck"] = MichaelLUK.Value.ToString();
            save["Michael.Equipment.Attatched"]["WEAPON"] = MichaelWeapon.Text;
            save["Michael.Equipment.Attatched"]["BODY"] = MichaelBody.Text;
            save["Michael.Equipment.Attatched"]["HEAD"] = MichaelHead.Text;
            save["Michael.Equipment.Attatched"]["OTHER"] = MichaelOther.Text;
            save["Michael.Equipment.Attatched"]["CLOTHES"] = MichaelBody.Text;
            save["Michael.Equipment.Attatched"]["HAT"] = MichaelHead.Text;
            save["Michael.Skills.Attatched"]["Photoshoot"] = Convert.ToString(Convert.ToInt32(MichaelSPhotoshoot.Checked));
            save["Michael.Skills.Attatched"]["Mug Shot"] = Convert.ToString(Convert.ToInt32(MichaelSMugShot.Checked));
            save["Michael.Skills.Attatched"]["Glamour Shot"] = Convert.ToString(Convert.ToInt32(MichaelSGlamourShot.Checked));
            save["Michael.Skills.Attatched"]["Soul Capture"] = Convert.ToString(Convert.ToInt32(MichaelSSoulCapture.Checked));
            save["Michael.Skills.Attatched"]["Scan"] = Convert.ToString(Convert.ToInt32(MichaelSScan.Checked));
            save["Michael"]["currentXp"] = MichaelEXP.Value.ToString();
            save["Vella"]["level"] = VellaLevel.Value.ToString();
            save["Vella"]["hp"] = VellaHP.Value.ToString();
            save["Vella"]["maxHP"] = VellaMHP.Value.ToString();
            save["Vella"]["pp"] = VellaPP.Value.ToString();
            save["Vella"]["maxPP"] = VellaMPP.Value.ToString();
            save["Vella"]["str"] = VellaSTR.Value.ToString();
            save["Vella"]["def"] = VellaDEF.Value.ToString();
            save["Vella"]["speed"] = VellaAGI.Value.ToString();
            save["Vella"]["luck"] = VellaLUK.Value.ToString();
            save["Vella.Equipment.Attatched"]["WEAPON"] = VellaWeapon.Text;
            save["Vella.Equipment.Attatched"]["BODY"] = VellaBody.Text;
            save["Vella.Equipment.Attatched"]["HEAD"] = VellaHead.Text;
            save["Vella.Equipment.Attatched"]["OTHER"] = VellaOther.Text;
            save["Vella.Equipment.Attatched"]["CLOTHES"] = VellaBody.Text;
            save["Vella.Equipment.Attatched"]["HAT"] = VellaHead.Text;
            save["Vella.Skills.Attatched"]["Banish"] = Convert.ToString(Convert.ToInt32(VellaSBanish.Checked));
            save["Vella.Skills.Attatched"]["Healing Song"] = Convert.ToString(Convert.ToInt32(VellaSHealingSong.Checked));
            save["Vella.Skills.Attatched"]["Feedback"] = Convert.ToString(Convert.ToInt32(VellaSFeedback.Checked));
            save["Vella.Skills.Attatched"]["Bass Drop"] = Convert.ToString(Convert.ToInt32(VellaSBassDrop.Checked));
            save["Vella.Skills.Attatched"]["Revive"] = Convert.ToString(Convert.ToInt32(VellaSRevive.Checked));
            save["Vella"]["currentXp"] = VellaEXP.Value.ToString();
            save["Rory"]["level"] = RoryLevel.Value.ToString();
            save["Rory"]["hp"] = RoryHP.Value.ToString();
            save["Rory"]["maxHP"] = RoryMHP.Value.ToString();
            save["Rory"]["pp"] = RoryPP.Value.ToString();
            save["Rory"]["maxPP"] = RoryMPP.Value.ToString();
            save["Rory"]["str"] = RorySTR.Value.ToString();
            save["Rory"]["def"] = RoryDEF.Value.ToString();
            save["Rory"]["speed"] = RoryAGI.Value.ToString();
            save["Rory"]["luck"] = RoryLUK.Value.ToString();
            save["Rory.Equipment.Attatched"]["WEAPON"] = RoryWeapon.Text;
            save["Rory.Equipment.Attatched"]["BODY"] = RoryBody.Text;
            save["Rory.Equipment.Attatched"]["HEAD"] = RoryHead.Text;
            save["Rory.Equipment.Attatched"]["OTHER"] = RoryOther.Text;
            save["Rory.Equipment.Attatched"]["CLOTHES"] = RoryBody.Text;
            save["Rory.Equipment.Attatched"]["HAT"] = RoryHead.Text;
            save["Rory.Skills.Attatched"]["HP/PP Swap"] = Convert.ToString(Convert.ToInt32(RorySSwap.Checked));
            save["Rory.Skills.Attatched"]["Protest"] = Convert.ToString(Convert.ToInt32(RorySProtest.Checked));
            save["Rory.Skills.Attatched"]["Holy Heal"] = Convert.ToString(Convert.ToInt32(RorySHolyHeal.Checked));
            save["Rory.Skills.Attatched"]["Sacrifice"] = Convert.ToString(Convert.ToInt32(RorySSacrafice.Checked));
            save["Rory.Skills.Attatched"]["Talk"] = Convert.ToString(Convert.ToInt32(RorySTalk.Checked));
            save["Rory"]["currentXp"] = RoryEXP.Value.ToString();
            save["Claudio"]["level"] = ClaudioLevel.Value.ToString();
            save["Claudio"]["hp"] = ClaudioHP.Value.ToString();
            save["Claudio"]["maxHP"] = ClaudioMHP.Value.ToString();
            save["Claudio"]["pp"] = ClaudioPP.Value.ToString();
            save["Claudio"]["maxPP"] = ClaudioMPP.Value.ToString();
            save["Claudio"]["str"] = ClaudioSTR.Value.ToString();
            save["Claudio"]["def"] = ClaudioDEF.Value.ToString();
            save["Claudio"]["speed"] = ClaudioAGI.Value.ToString();
            save["Claudio"]["luck"] = ClaudioLUK.Value.ToString();
            save["Claudio.Equipment.Attatched"]["WEAPON"] = ClaudioWeapon.Text;
            save["Claudio.Equipment.Attatched"]["BODY"] = ClaudioBody.Text;
            save["Claudio.Equipment.Attatched"]["HEAD"] = ClaudioHead.Text;
            save["Claudio.Equipment.Attatched"]["OTHER"] = ClaudioOther.Text;
            save["Claudio.Equipment.Attatched"]["CLOTHES"] = ClaudioBody.Text;
            save["Claudio.Equipment.Attatched"]["HAT"] = ClaudioHead.Text;
            save["Claudio.Skills.Attatched"]["BushidoHack"] = Convert.ToString(Convert.ToInt32(ClaudioSBushido.Checked));
            save["Claudio"]["currentXp"] = ClaudioEXP.Value.ToString();
            save["Chondra"]["level"] = ChondraLevel.Value.ToString();
            save["Chondra"]["hp"] = ChondraHP.Value.ToString();
            save["Chondra"]["maxHP"] = ChondraMHP.Value.ToString();
            save["Chondra"]["pp"] = ChondraPP.Value.ToString();
            save["Chondra"]["maxPP"] = ChondraMPP.Value.ToString();
            save["Chondra"]["str"] = ChondraSTR.Value.ToString();
            save["Chondra"]["def"] = ChondraDEF.Value.ToString();
            save["Chondra"]["speed"] = ChondraAGI.Value.ToString();
            save["Chondra"]["luck"] = ChondraLUK.Value.ToString();
            save["Chondra.Equipment.Attatched"]["WEAPON"] = ChondraWeapon.Text;
            save["Chondra.Equipment.Attatched"]["BODY"] = ChondraBody.Text;
            save["Chondra.Equipment.Attatched"]["HEAD"] = ChondraHead.Text;
            save["Chondra.Equipment.Attatched"]["OTHER"] = ChondraOther.Text;
            save["Chondra.Equipment.Attatched"]["CLOTHES"] = ChondraBody.Text;
            save["Chondra.Equipment.Attatched"]["HAT"] = ChondraHead.Text;
            save["Chondra.Skills.Attatched"]["Hula Stance"] = Convert.ToString(Convert.ToInt32(ChondraSHulaStance.Checked));
            save["Chondra.Skills.Attatched"]["Wild Stance"] = Convert.ToString(Convert.ToInt32(ChondraSWildStance.Checked));
            save["Chondra.Skills.Attatched"]["Strong Stance"] = Convert.ToString(Convert.ToInt32(ChondraSStrongStance.Checked));
            save["Chondra.Skills.Attatched"]["Devil Stance"] = Convert.ToString(Convert.ToInt32(ChondraSDevilStance.Checked));
            save["Chondra.Skills.Attatched"]["Spread Item"] = Convert.ToString(Convert.ToInt32(ChondraSSpreadItem.Checked));
            save["Chondra.Skills.Attatched"]["Chuck Item"] = Convert.ToString(Convert.ToInt32(ChondraSChuckItem.Checked));
            save["Chondra"]["currentXp"] = ChondraEXP.Value.ToString();
            save["The Essentia 2000"]["level"] = EssentiaLevel.Value.ToString();
            save["The Essentia 2000"]["hp"] = EssentiaHP.Value.ToString();
            save["The Essentia 2000"]["maxHP"] = EssentiaMHP.Value.ToString();
            save["The Essentia 2000"]["pp"] = EssentiaPP.Value.ToString();
            save["The Essentia 2000"]["maxPP"] = EssentiaMPP.Value.ToString();
            save["The Essentia 2000"]["str"] = EssentiaSTR.Value.ToString();
            save["The Essentia 2000"]["def"] = EssentiaDEF.Value.ToString();
            save["The Essentia 2000"]["speed"] = EssentiaAGI.Value.ToString();
            save["The Essentia 2000"]["luck"] = EssentiaLUK.Value.ToString();
            save["The Essentia 2000.Equipment.Attatched"]["WEAPON"] = EssentiaWeapon.Text;
            save["The Essentia 2000.Equipment.Attatched"]["BODY"] = EssentiaBody.Text;
            save["The Essentia 2000.Equipment.Attatched"]["HEAD"] = EssentiaHead.Text;
            save["The Essentia 2000.Equipment.Attatched"]["OTHER"] = EssentiaOther.Text;
            save["The Essentia 2000.Equipment.Attatched"]["CLOTHES"] = EssentiaBody.Text;
            save["The Essentia 2000.Equipment.Attatched"]["HAT"] = EssentiaHead.Text;
            save["The Essentia 2000.Skills.Attatched"]["Missile Launcher"] = Convert.ToString(Convert.ToInt32(EssentiaSMissileLauncher.Checked));
            save["The Essentia 2000.Skills.Attatched"]["Sleep Shot"] = Convert.ToString(Convert.ToInt32(EssentiaSSleepShot.Checked));
            save["The Essentia 2000.Skills.Attatched"]["Machine Gun"] = Convert.ToString(Convert.ToInt32(EssentiaSMachineGun.Checked));
            save["The Essentia 2000.Skills.Attatched"]["Self Destruct"] = Convert.ToString(Convert.ToInt32(EssentiaSSelfDestruct.Checked));
            save["The Essentia 2000"]["currentXp"] = EssentiaEXP.Value.ToString();
            save["Sammy"]["level"] = SammyLevel.Value.ToString();
            save["Sammy"]["hp"] = SammyHP.Value.ToString();
            save["Sammy"]["maxHP"] = SammyMHP.Value.ToString();
            save["Sammy"]["pp"] = SammyPP.Value.ToString();
            save["Sammy"]["maxPP"] = SammyMPP.Value.ToString();
            save["Sammy"]["str"] = SammySTR.Value.ToString();
            save["Sammy"]["def"] = SammyDEF.Value.ToString();
            save["Sammy"]["speed"] = SammyAGI.Value.ToString();
            save["Sammy"]["luck"] = SammyLUK.Value.ToString();
            save["Sammy.Equipment.Attatched"]["WEAPON"] = SammyWeapon.Text;
            save["Sammy.Equipment.Attatched"]["BODY"] = SammyBody.Text;
            save["Sammy.Equipment.Attatched"]["HEAD"] = SammyHead.Text;
            save["Sammy.Equipment.Attatched"]["OTHER"] = SammyOther.Text;
            save["Sammy.Equipment.Attatched"]["CLOTHES"] = SammyBody.Text;
            save["Sammy.Equipment.Attatched"]["HAT"] = SammyHead.Text;
            save["Sammy.Skills.Attatched"]["Healing Song"] = Convert.ToString(Convert.ToInt32(SammySHealingSong.Checked));
            save["Sammy.Skills.Attatched"]["Rally"] = Convert.ToString(Convert.ToInt32(SammySRally.Checked));
            save["Sammy"]["currentXp"] = SammyEXP.Value.ToString();
            save["SystemDataGroup"]["menuStyle"] = Convert.ToString(UIColor.Value);
            save["SystemDataGroup"]["Playtime"] = PlaytimeBox.Text;
            save["Settings"]["Controller"] = Convert.ToString(Controller.Value);
            save["Settings"]["AssistMode"] = Convert.ToString(Convert.ToInt32(AssistMode.Checked));
            save["GodMode"]["FastForward"] = Convert.ToString(Convert.ToInt32(GodMode.Checked));
            save["Audio.Settings"]["MUSIC_VOLUME"] = Convert.ToString(MusicVolume.Value);
            save["Audio.Settings"]["SFX_VOLUME"] = Convert.ToString(SFXVolume.Value);
            save["Audio.Settings"]["VOICE_VOLUME"] = Convert.ToString(VoiceVolume.Value);
            save["Audio.Settings"]["MASTER_VOLUME"] = Convert.ToString(MasterVolume.Value);
            save["Tools"]["PandaTool"] = Convert.ToString(Convert.ToInt32(ToolPanda.Checked));
            save["Tools"]["CatTool"] = Convert.ToString(Convert.ToInt32(ToolDali.Checked));
            save["Tools"]["Amp"] = Convert.ToString(Convert.ToInt32(ToolAmp.Checked));
            save["Tools"]["HairWhip"] = Convert.ToString(Convert.ToInt32(ToolHairwhip.Checked));
            save["Tools"]["Skateboard"] = Convert.ToString(Convert.ToInt32(ToolSkateboard.Checked));
            save["Tools"]["FlameThrowerTool"] = Convert.ToString(Convert.ToInt32(ToolFlamethrower.Checked));
            save["Tools"]["MonsterWhistle"] = Convert.ToString(Convert.ToInt32(ToolWhistle.Checked));
            
        }
        public void loadSaveData()
        {
            if (save["SystemDataGroup"].ContainsKey("menuStyle"))
            {
                UIColor.Value = int.Parse(save["SystemDataGroup"]["menuStyle"]);
            }
            else UIColor.Value = 1;
            // Alex handling
            if (save["Alex"] != null)
            {
                ClassAlex.Text = save["Alex"]["classification"];
                InPartyAlex.Checked = Convert.ToBoolean(int.Parse(save["Alex"]["isInParty"]));
                AlexLevel.Value = int.Parse(save["Alex"]["level"]);
                AlexHP.Value = int.Parse(save["Alex"]["hp"]);
                AlexMHP.Value = int.Parse(save["Alex"]["maxHP"]);
                AlexPP.Value = int.Parse(save["Alex"]["pp"]);
                AlexMPP.Value = int.Parse(save["Alex"]["maxPP"]);
                AlexSTR.Value = int.Parse(save["Alex"]["str"]);
                AlexDEF.Value = int.Parse(save["Alex"]["def"]);
                AlexAGI.Value = int.Parse(save["Alex"]["speed"]);
                AlexLUK.Value = int.Parse(save["Alex"]["luck"]);
                AlexWeapon.Text = save["Alex.Equipment.Attatched"]["WEAPON"];
                AlexBody.Text = save["Alex.Equipment.Attatched"]["BODY"];
                AlexHead.Text = save["Alex.Equipment.Attatched"]["HEAD"];
                AlexOther.Text = save["Alex.Equipment.Attatched"]["OTHER"];
                AlexEXP.Value = int.Parse(save["Alex"]["currentXp"]);
                if (save["Alex.Skills.AsItems"].ContainsKey("Panda Barrier")) AlexSPandaBarrier.Checked = Convert.ToBoolean(int.Parse(save["Alex.Skills.AsItems"]["Panda Barrier"]));
                if (save["Alex.Skills.AsItems"].ContainsKey("Smooth Jazz")) AlexSSmoothJazz.Checked = Convert.ToBoolean(int.Parse(save["Alex.Skills.AsItems"]["Smooth Jazz"]));
                if (save["Alex.Skills.AsItems"].ContainsKey("LP Toss")) AlexSLPToss.Checked = Convert.ToBoolean(int.Parse(save["Alex.Skills.AsItems"]["LP Toss"]));
                if (save["Alex.Skills.AsItems"].ContainsKey("EP Strike")) AlexSEPStrike.Checked = Convert.ToBoolean(int.Parse(save["Alex.Skills.AsItems"]["EP Strike"]));
            } else
            {
                ClassAlex.Text = "Graduate";
                InPartyAlex.Checked = true;
                AlexLevel.Value = 1;
                AlexHP.Value = 10;
                AlexMHP.Value = 10;
                AlexPP.Value = 5;
                AlexMPP.Value = 5;
                AlexSTR.Value = 1;
                AlexDEF.Value = 3;
                AlexAGI.Value = 24;
                AlexLUK.Value = 15;
                AlexWeapon.Text = "";
                AlexBody.Text = "";
                AlexHead.Text = "";
                AlexOther.Text = "";
                AlexEXP.Value = 0;
            }
            // Michael handling
            if (save["Michael"] != null)
            {
                ClassMichael.Text = save["Michael"]["classification"];
                InPartyMichael.Checked = Convert.ToBoolean(int.Parse(save["Michael"]["isInParty"]));
                MichaelLevel.Value = int.Parse(save["Michael"]["level"]);
                MichaelHP.Value = int.Parse(save["Michael"]["hp"]);
                MichaelMHP.Value = int.Parse(save["Michael"]["maxHP"]);
                MichaelPP.Value = int.Parse(save["Michael"]["pp"]);
                MichaelMPP.Value = int.Parse(save["Michael"]["maxPP"]);
                MichaelSTR.Value = int.Parse(save["Michael"]["str"]);
                MichaelDEF.Value = int.Parse(save["Michael"]["def"]);
                MichaelAGI.Value = int.Parse(save["Michael"]["speed"]);
                MichaelLUK.Value = int.Parse(save["Michael"]["luck"]);
                MichaelWeapon.Text = save["Michael.Equipment.Attatched"]["WEAPON"];
                MichaelBody.Text = save["Michael.Equipment.Attatched"]["BODY"];
                MichaelHead.Text = save["Michael.Equipment.Attatched"]["HEAD"];
                MichaelOther.Text = save["Michael.Equipment.Attatched"]["OTHER"];
                MichaelEXP.Value = int.Parse(save["Michael"]["currentXp"]);
                if (save["Michael.Skills.AsItems"].ContainsKey("Photoshoot")) MichaelSPhotoshoot.Checked = Convert.ToBoolean(int.Parse(save["Michael.Skills.AsItems"]["Photoshoot"]));
                if (save["Michael.Skills.AsItems"].ContainsKey("Mug Shot")) MichaelSMugShot.Checked = Convert.ToBoolean(int.Parse(save["Michael.Skills.AsItems"]["Mug Shot"]));
                if (save["Michael.Skills.AsItems"].ContainsKey("Glamour Shot")) MichaelSGlamourShot.Checked = Convert.ToBoolean(int.Parse(save["Michael.Skills.AsItems"]["Glamour Shot"]));
                if (save["Michael.Skills.AsItems"].ContainsKey("Scan")) MichaelSScan.Checked = Convert.ToBoolean(int.Parse(save["Michael.Skills.AsItems"]["Scan"]));
                if (save["Michael.Skills.AsItems"].ContainsKey("Soul Capture")) MichaelSSoulCapture.Checked = Convert.ToBoolean(int.Parse(save["Michael.Skills.AsItems"]["Soul Capture"]));
            }
            else
            {
                ClassMichael.Text = "Conspiracy Theorist";
                InPartyMichael.Checked = false;
                MichaelLevel.Value = 1;
                MichaelHP.Value = 8;
                MichaelMHP.Value = 8;
                MichaelPP.Value = 6;
                MichaelMPP.Value = 6;
                MichaelSTR.Value = 4;
                MichaelDEF.Value = 2;
                MichaelAGI.Value = 22;
                MichaelLUK.Value = 18;
                MichaelWeapon.Text = "";
                MichaelBody.Text = "";
                MichaelHead.Text = "";
                MichaelOther.Text = "";
                MichaelEXP.Value = 0;
                MichaelSPhotoshoot.Checked = true;
            }
            if (save["Vella"] != null)
            {
                ClassVella.Text = save["Vella"]["classification"];
                InPartyVella.Checked = Convert.ToBoolean(int.Parse(save["Vella"]["isInParty"]));
                VellaLevel.Value = int.Parse(save["Vella"]["level"]);
                VellaHP.Value = int.Parse(save["Vella"]["hp"]);
                VellaMHP.Value = int.Parse(save["Vella"]["maxHP"]);
                VellaPP.Value = int.Parse(save["Vella"]["pp"]);
                VellaMPP.Value = int.Parse(save["Vella"]["maxPP"]);
                VellaSTR.Value = int.Parse(save["Vella"]["str"]);
                VellaDEF.Value = int.Parse(save["Vella"]["def"]);
                VellaAGI.Value = int.Parse(save["Vella"]["speed"]);
                VellaLUK.Value = int.Parse(save["Vella"]["luck"]);
                VellaWeapon.Text = save["Vella.Equipment.Attatched"]["WEAPON"];
                VellaBody.Text = save["Vella.Equipment.Attatched"]["BODY"];
                VellaHead.Text = save["Vella.Equipment.Attatched"]["HEAD"];
                VellaOther.Text = save["Vella.Equipment.Attatched"]["OTHER"];
                VellaEXP.Value = int.Parse(save["Vella"]["currentXp"]);
                if (save["Vella.Skills.AsItems"].ContainsKey("Banish")) VellaSBanish.Checked = Convert.ToBoolean(int.Parse(save["Vella.Skills.AsItems"]["Banish"]));
                if (save["Vella.Skills.AsItems"].ContainsKey("Healing Song")) VellaSHealingSong.Checked = Convert.ToBoolean(int.Parse(save["Vella.Skills.AsItems"]["Healing Song"]));
                if (save["Vella.Skills.AsItems"].ContainsKey("Feedback")) VellaSBanish.Checked = Convert.ToBoolean(int.Parse(save["Vella.Skills.AsItems"]["Feedback"]));
                if (save["Vella.Skills.AsItems"].ContainsKey("Bass Drop")) VellaSBassDrop.Checked = Convert.ToBoolean(int.Parse(save["Vella.Skills.AsItems"]["Bass Drop"]));
                if (save["Vella.Skills.AsItems"].ContainsKey("Revive")) VellaSRevive.Checked = Convert.ToBoolean(int.Parse(save["Vella.Skills.AsItems"]["Revive"]));
            }
            else
            {
                ClassVella.Text = "Heartbreaker";
                InPartyVella.Checked = false;
                VellaLevel.Value = 1;
                VellaHP.Value = 13;
                VellaMHP.Value = 13;
                VellaPP.Value = 8;
                VellaMPP.Value = 8;
                VellaSTR.Value = 3;
                VellaDEF.Value = 4;
                VellaAGI.Value = 23;
                VellaLUK.Value = 11;
                VellaWeapon.Text = "";
                VellaBody.Text = "";
                VellaHead.Text = "";
                VellaOther.Text = "";
                VellaEXP.Value = 0;
                VellaSBanish.Checked = true;
            }
            if (save["Rory"] != null)
            {
                ClassRory.Text = save["Rory"]["classification"];
                InPartyRory.Checked = Convert.ToBoolean(int.Parse(save["Rory"]["isInParty"]));
                RoryLevel.Value = int.Parse(save["Rory"]["level"]);
                RoryHP.Value = int.Parse(save["Rory"]["hp"]);
                RoryMHP.Value = int.Parse(save["Rory"]["maxHP"]);
                RoryPP.Value = int.Parse(save["Rory"]["pp"]);
                RoryMPP.Value = int.Parse(save["Rory"]["maxPP"]);
                RorySTR.Value = int.Parse(save["Rory"]["str"]);
                RoryDEF.Value = int.Parse(save["Rory"]["def"]);
                RoryAGI.Value = int.Parse(save["Rory"]["speed"]);
                RoryLUK.Value = int.Parse(save["Rory"]["luck"]);
                RoryWeapon.Text = save["Rory.Equipment.Attatched"]["WEAPON"];
                RoryBody.Text = save["Rory.Equipment.Attatched"]["BODY"];
                RoryHead.Text = save["Rory.Equipment.Attatched"]["HEAD"];
                RoryOther.Text = save["Rory.Equipment.Attatched"]["OTHER"];
                RoryEXP.Value = int.Parse(save["Rory"]["currentXp"]);
                if (save["Rory.Skills.AsItems"].ContainsKey("HP/PP Swap")) RorySSwap.Checked = Convert.ToBoolean(int.Parse(save["Rory.Skills.AsItems"]["HP/PP Swap"]));
                if (save["Rory.Skills.AsItems"].ContainsKey("Talk")) RorySTalk.Checked = Convert.ToBoolean(int.Parse(save["Rory.Skills.AsItems"]["Talk"]));
                if (save["Rory.Skills.AsItems"].ContainsKey("Protest")) RorySProtest.Checked = Convert.ToBoolean(int.Parse(save["Rory.Skills.AsItems"]["Protest"]));
                if (save["Rory.Skills.AsItems"].ContainsKey("Sacrifice")) RorySSacrafice.Checked = Convert.ToBoolean(int.Parse(save["Rory.Skills.AsItems"]["Sacrifice"]));
                if (save["Rory.Skills.AsItems"].ContainsKey("Holy Heal")) RorySHolyHeal.Checked = Convert.ToBoolean(int.Parse(save["Rory.Skills.AsItems"]["Holy Heal"]));
            }
            else
            {
                ClassRory.Text = "Loner";
                InPartyRory.Checked = false;
                RoryLevel.Value = 1;
                RoryHP.Value = 9;
                RoryMHP.Value = 9;
                RoryPP.Value = 14;
                RoryMPP.Value = 14;
                RorySTR.Value = 1;
                RoryDEF.Value = 8;
                RoryAGI.Value = 23;
                RoryLUK.Value = 16;
                RoryWeapon.Text = "";
                RoryBody.Text = "";
                RoryHead.Text = "";
                RoryOther.Text = "";
                RoryEXP.Value = 0;
                RorySSwap.Checked = true;
            }
            if (save["Claudio"] != null)
            {
                ClassClaudio.Text = save["Claudio"]["classification"];
                InPartyClaudio.Checked = Convert.ToBoolean(int.Parse(save["Claudio"]["isInParty"]));
                ClaudioLevel.Value = int.Parse(save["Claudio"]["level"]);
                ClaudioHP.Value = int.Parse(save["Claudio"]["hp"]);
                ClaudioMHP.Value = int.Parse(save["Claudio"]["maxHP"]);
                ClaudioPP.Value = int.Parse(save["Claudio"]["pp"]);
                ClaudioMPP.Value = int.Parse(save["Claudio"]["maxPP"]);
                ClaudioSTR.Value = int.Parse(save["Claudio"]["str"]);
                ClaudioDEF.Value = int.Parse(save["Claudio"]["def"]);
                ClaudioAGI.Value = int.Parse(save["Claudio"]["speed"]);
                ClaudioLUK.Value = int.Parse(save["Claudio"]["luck"]);
                ClaudioWeapon.Text = save["Claudio.Equipment.Attatched"]["WEAPON"];
                ClaudioBody.Text = save["Claudio.Equipment.Attatched"]["BODY"];
                ClaudioHead.Text = save["Claudio.Equipment.Attatched"]["HEAD"];
                ClaudioOther.Text = save["Claudio.Equipment.Attatched"]["OTHER"];
                ClaudioEXP.Value = int.Parse(save["Claudio"]["currentXp"]);
                if (save["Claudio.Skills.AsItems"].ContainsKey("BushidoHack")) ClaudioSBushido.Checked = Convert.ToBoolean(int.Parse(save["Claudio.Skills.AsItems"]["BushidoHack"]));
            }
            else
            {
                ClassClaudio.Text = "Samurai";
                InPartyClaudio.Checked = false;
                ClaudioLevel.Value = 1;
                ClaudioHP.Value = 10;
                ClaudioMHP.Value = 10;
                ClaudioPP.Value = 3;
                ClaudioMPP.Value = 3;
                ClaudioSTR.Value = 6;
                ClaudioDEF.Value = 2;
                ClaudioAGI.Value = 12;
                ClaudioLUK.Value = 15;
                ClaudioWeapon.Text = "";
                ClaudioBody.Text = "";
                ClaudioHead.Text = "";
                ClaudioOther.Text = "";
                ClaudioEXP.Value = 0;
                ClaudioSBushido.Checked = true;
            }
            if (save["Chondra"] != null)
            {
                ClassChondra.Text = save["Chondra"]["classification"];
                InPartyChondra.Checked = Convert.ToBoolean(int.Parse(save["Chondra"]["isInParty"]));
                ChondraLevel.Value = int.Parse(save["Chondra"]["level"]);
                ChondraHP.Value = int.Parse(save["Chondra"]["hp"]);
                ChondraMHP.Value = int.Parse(save["Chondra"]["maxHP"]);
                ChondraPP.Value = int.Parse(save["Chondra"]["pp"]);
                ChondraMPP.Value = int.Parse(save["Chondra"]["maxPP"]);
                ChondraSTR.Value = int.Parse(save["Chondra"]["str"]);
                ChondraDEF.Value = int.Parse(save["Chondra"]["def"]);
                ChondraAGI.Value = int.Parse(save["Chondra"]["speed"]);
                ChondraLUK.Value = int.Parse(save["Chondra"]["luck"]);
                ChondraWeapon.Text = save["Chondra.Equipment.Attatched"]["WEAPON"];
                ChondraBody.Text = save["Chondra.Equipment.Attatched"]["BODY"];
                ChondraHead.Text = save["Chondra.Equipment.Attatched"]["HEAD"];
                ChondraOther.Text = save["Chondra.Equipment.Attatched"]["OTHER"];
                ChondraEXP.Value = int.Parse(save["Chondra"]["currentXp"]);
                if (save["Chondra.Skills.AsItems"].ContainsKey("Spread Item")) ChondraSSpreadItem.Checked = Convert.ToBoolean(int.Parse(save["Chondra.Skills.AsItems"]["Spread Item"]));
                if (save["Chondra.Skills.AsItems"].ContainsKey("Chuck Item")) ChondraSChuckItem.Checked = Convert.ToBoolean(int.Parse(save["Chondra.Skills.AsItems"]["Chuck Item"]));
                if (save["Chondra.Skills.AsItems"].ContainsKey("Hula Stance")) ChondraSHulaStance.Checked = Convert.ToBoolean(int.Parse(save["Chondra.Skills.AsItems"]["Hula Stance"]));
                if (save["Chondra.Skills.AsItems"].ContainsKey("Wild Stance")) ChondraSWildStance.Checked = Convert.ToBoolean(int.Parse(save["Chondra.Skills.AsItems"]["Wild Stance"]));
                if (save["Chondra.Skills.AsItems"].ContainsKey("Strong Stance")) ChondraSStrongStance.Checked = Convert.ToBoolean(int.Parse(save["Chondra.Skills.AsItems"]["Strong Stance"]));
                if (save["Chondra.Skills.AsItems"].ContainsKey("Devil Stance")) ChondraSDevilStance.Checked = Convert.ToBoolean(int.Parse(save["Chondra.Skills.AsItems"]["Devil Stance"]));
            }
            else
            {
                ClassChondra.Text = "Loner";
                InPartyChondra.Checked = false;
                ChondraLevel.Value = 1;
                ChondraHP.Value = 9;
                ChondraMHP.Value = 9;
                ChondraPP.Value = 14;
                ChondraMPP.Value = 14;
                ChondraSTR.Value = 1;
                ChondraDEF.Value = 8;
                ChondraAGI.Value = 23;
                ChondraLUK.Value = 16;
                ChondraWeapon.Text = "";
                ChondraBody.Text = "";
                ChondraHead.Text = "";
                ChondraOther.Text = "";
                ChondraEXP.Value = 0;
                ChondraSSpreadItem.Checked = true;
                ChondraSHulaStance.Checked = true;
                ChondraSWildStance.Checked = true;
                ChondraSStrongStance.Checked = true;
                ChondraSDevilStance.Checked = true;
            }
            if (save["The Essentia 2000"] != null)
            {
                ClassEssentia.Text = save["The Essentia 2000"]["classification"];
                InPartyEssentia.Checked = Convert.ToBoolean(int.Parse(save["The Essentia 2000"]["isInParty"]));
                EssentiaLevel.Value = int.Parse(save["The Essentia 2000"]["level"]);
                EssentiaHP.Value = int.Parse(save["The Essentia 2000"]["hp"]);
                EssentiaMHP.Value = int.Parse(save["The Essentia 2000"]["maxHP"]);
                EssentiaPP.Value = int.Parse(save["The Essentia 2000"]["pp"]);
                EssentiaMPP.Value = int.Parse(save["The Essentia 2000"]["maxPP"]);
                EssentiaSTR.Value = int.Parse(save["The Essentia 2000"]["str"]);
                EssentiaDEF.Value = int.Parse(save["The Essentia 2000"]["def"]);
                EssentiaAGI.Value = int.Parse(save["The Essentia 2000"]["speed"]);
                EssentiaLUK.Value = int.Parse(save["The Essentia 2000"]["luck"]);
                EssentiaWeapon.Text = save["The Essentia 2000.Equipment.Attatched"]["WEAPON"];
                EssentiaBody.Text = save["The Essentia 2000.Equipment.Attatched"]["BODY"];
                EssentiaHead.Text = save["The Essentia 2000.Equipment.Attatched"]["HEAD"];
                EssentiaOther.Text = save["The Essentia 2000.Equipment.Attatched"]["OTHER"];
                EssentiaEXP.Value = int.Parse(save["The Essentia 2000"]["currentXp"]);
                EssentiaSMissileLauncher.Checked = Convert.ToBoolean(int.Parse(save["The Essentia 2000.Skills.AsItems"]["Missile Launcher"]));
                EssentiaSSleepShot.Checked = Convert.ToBoolean(int.Parse(save["The Essentia 2000.Skills.AsItems"]["Sleep Shot"]));
                EssentiaSMachineGun.Checked = Convert.ToBoolean(int.Parse(save["The Essentia 2000.Skills.AsItems"]["Machine Gun"]));
                EssentiaSSelfDestruct.Checked = Convert.ToBoolean(int.Parse(save["The Essentia 2000.Skills.AsItems"]["Self Destruct"]));
            }
            else
            {
                ClassEssentia.Text = "Pan-Dimensional Android";
                InPartyEssentia.Checked = false;
                EssentiaLevel.Value = 1;
                EssentiaHP.Value = 14;
                EssentiaMHP.Value = 14;
                EssentiaPP.Value = 5;
                EssentiaMPP.Value = 5;
                EssentiaSTR.Value = 5;
                EssentiaDEF.Value = 12;
                EssentiaAGI.Value = 16;
                EssentiaLUK.Value = 21;
                EssentiaWeapon.Text = "";
                EssentiaBody.Text = "";
                EssentiaHead.Text = "";
                EssentiaOther.Text = "";
                EssentiaEXP.Value = 0;
                EssentiaSMissileLauncher.Checked = true;
                EssentiaSSleepShot.Checked = true;
                EssentiaSMachineGun.Checked = true;
                EssentiaSSelfDestruct.Checked = true;
            }
            if (save["Sammy"] != null)
            {
                ClassSammy.Text = save["Sammy"]["classification"];
                InPartySammy.Checked = Convert.ToBoolean(int.Parse(save["Sammy"]["isInParty"]));
                SammyLevel.Value = int.Parse(save["Sammy"]["level"]);
                SammyHP.Value = int.Parse(save["Sammy"]["hp"]);
                SammyMHP.Value = int.Parse(save["Sammy"]["maxHP"]);
                SammyPP.Value = int.Parse(save["Sammy"]["pp"]);
                SammyMPP.Value = int.Parse(save["Sammy"]["maxPP"]);
                SammySTR.Value = int.Parse(save["Sammy"]["str"]);
                SammyDEF.Value = int.Parse(save["Sammy"]["def"]);
                SammyAGI.Value = int.Parse(save["Sammy"]["speed"]);
                SammyLUK.Value = int.Parse(save["Sammy"]["luck"]);
                SammyWeapon.Text = save["Sammy.Equipment.Attatched"]["WEAPON"];
                SammyBody.Text = save["Sammy.Equipment.Attatched"]["BODY"];
                SammyHead.Text = save["Sammy.Equipment.Attatched"]["HEAD"];
                SammyOther.Text = save["Sammy.Equipment.Attatched"]["OTHER"];
                SammyEXP.Value = int.Parse(save["Sammy"]["currentXp"]);
                SammySHealingSong.Checked = Convert.ToBoolean(int.Parse(save["Sammy.Skills.AsItems"]["Healing Song"]));
                SammySRally.Checked = Convert.ToBoolean(int.Parse(save["Sammy.Skills.AsItems"]["Rally"]));
            }
            else
            {
                ClassSammy.Text = "Cat Person";
                InPartySammy.Checked = false;
                SammyLevel.Value = 1;
                SammyHP.Value = 8;
                SammyMHP.Value = 8;
                SammyPP.Value = 7;
                SammyMPP.Value = 7;
                SammySTR.Value = 2;
                SammyDEF.Value = 2;
                SammyAGI.Value = 9;
                SammyLUK.Value = 18;
                SammyWeapon.Text = "";
                SammyBody.Text = "";
                SammyHead.Text = "";
                SammyOther.Text = "";
                SammyEXP.Value = 0;
                SammySHealingSong.Checked = true;
                SammySRally.Checked = true;
            }
            PlaytimeBox.Text = save["SystemDataGroup"]["Playtime"];
            if (save["Settings"].ContainsKey("Controller")) Controller.Value = int.Parse(save["Settings"]["Controller"]);
            if (save["Settings"].ContainsKey("AssistMode")) AssistMode.Checked = Convert.ToBoolean(int.Parse(save["Settings"]["AssistMode"]));
            if (save["GodMode"].ContainsKey("FastForward")) GodMode.Checked = Convert.ToBoolean(int.Parse(save["GodMode"]["FastForward"]));
            MusicVolume.Value = int.Parse(save["Audio.Settings"]["MUSIC_VOLUME"]);
            SFXVolume.Value = int.Parse(save["Audio.Settings"]["SFX_VOLUME"]);
            VoiceVolume.Value = int.Parse(save["Audio.Settings"]["VOICE_VOLUME"]);
            MasterVolume.Value = int.Parse(save["Audio.Settings"]["MASTER_VOLUME"]);
            if (save["Tools"].ContainsKey("PandaTool")) ToolPanda.Checked = Convert.ToBoolean(int.Parse(save["Tools"]["PandaTool"]));
            if (save["Tools"].ContainsKey("CatTool")) ToolDali.Checked = Convert.ToBoolean(int.Parse(save["Tools"]["CatTool"]));
            if (save["Tools"].ContainsKey("Amp")) ToolAmp.Checked = Convert.ToBoolean(int.Parse(save["Tools"]["Amp"]));
            if (save["Tools"].ContainsKey("HairWhip")) ToolHairwhip.Checked = Convert.ToBoolean(int.Parse(save["Tools"]["HairWhip"]));
            if (save["Tools"].ContainsKey("Skateboard")) ToolSkateboard.Checked = Convert.ToBoolean(int.Parse(save["Tools"]["Skateboard"]));
            if (save["Tools"].ContainsKey("FlameThrowerTool")) ToolFlamethrower.Checked = Convert.ToBoolean(int.Parse(save["Tools"]["FlameThrowerTool"]));
            if (save["Tools"].ContainsKey("MonsterWhistle")) ToolWhistle.Checked = Convert.ToBoolean(int.Parse(save["Tools"]["MonsterWhistle"]));
            ItemList();
        }
        private void ItemList()
        {
            InventoryBox.Items.Clear();
            items = new List<InventoryItem>();
            for (int i = 0; i < save["InventoryContents"].Count; i++)
            {
                KeyData k = save["InventoryContents"].ElementAt(i);
                items.Add(new InventoryItem(k.KeyName, int.Parse(k.Value)));
            }

            for (int i = 0; i < items.Count; i++)
            {
                InventoryBox.Items.Add(items[i].Name + " (" + items[i].Count + ")");
            }
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Version 1.02. " +
                $"Developed by StarlightLune with help from firubii.", "YIIK: A Postmodern Save Editor");
        }

        private void Enemies_Factory_Click(object sender, EventArgs e)
        {
            save["EnemyDefeated_ExteriorFactoryScene"]["FactExtEnem1"] = "0";
            save["EnemyDefeated_ExteriorFactoryScene"]["FactExtEnem0"] = "0";
            save["EnemyDefeated_Factory_floorTwoSceneNew"]["FactoryDngnEnemy0"] = "0";
            save["EnemyDefeated_Factory_floorTwoSceneNew"]["FactoryDngnEnemy4"] = "0";
            save["EnemyDefeated_FactoryFloor4_3"]["FactoryDngnEnemy6"] = "0";
            save["EnemyDefeated_FactoryFloor4_3"]["FactoryDngnEnemy5"] = "0";
            save["EnemyDefeated_FactoryFloor4_3"]["FactoryDngnEnemy2"] = "0";
            save["EnemyDefeated_FactoryFloor4_3"]["FactoryDngnEnemy8"] = "0";
            save["EnemyDefeated_FactoryFloor4_3"]["FactoryDngnEnemy7"] = "0";
            MessageBox.Show("Reset encounters for Factory Hotel!");
        }

        private void Enemies_WindTown_Click(object sender, EventArgs e)
        {
            save["EnemyDefeated_SewerWindTownNesPartOne"]["SewerEnemiesAgrB"] = "0";
            save["EnemyDefeated_SewerWindTownNesPartOne"]["SewerRoomFour_2"] = "0";
            save["EnemyDefeated_SewerWindTownNesPartOne"]["SewerEnemiesGrdH"] = "0";
            save["EnemyDefeated_SewerWindTownNesPartOne"]["SewerRoomFour_2B"] = "0";
            save["EnemyDefeated_SewerWindTownNesPartOne"]["SewerRoomFour_2Cy"] = "0";
            save["EnemyDefeated_SewerWindTownNesPartOne"]["SewerEnemies3"] = "0";
            save["EnemyDefeated_SewerWindTownNesPartTwo"]["SewerPipeTurtle3"] = "0";
            save["EnemyDefeated_SewerWindTownNesPartTwo"]["SewerPipeTurtle2"] = "0";
            save["EnemyDefeated_SewerWindTownNesPartTwo"]["SewerPipeTurtle1"] = "0";
            MessageBox.Show("Reset encounters for Wind Town Sewer!");
        }

        private void Enemies_Mountain_Click(object sender, EventArgs e)
        {
            save["EnemyDefeated_FranktonMountain_RadioTower"]["RadioMountain1"] = "0";
            save["EnemyDefeated_FranktonMountain_RadioTower"]["RadioMountain2"] = "0";
            save["EnemyDefeated_FranktonMountain_RadioTower"]["RadioMountain5"] = "0";
            save["EnemyDefeated_FranktonMountain_RadioTower"]["RadioMountain9"] = "0";
            save["EnemyDefeated_FranktonMountain_RadioTower"]["RadioMountain6"] = "0";
            save["EnemyDefeated_FranktonMountain_RadioTower"]["RadioMountain13"] = "0";
            MessageBox.Show("Reset encounters for Radio Tower Mountain!");
        }

        private void Enemies_MtTown_Click(object sender, EventArgs e)
        {
            save["EnemyDefeated_MarksTown_Cave"]["MarksMountain20"] = "0";
            save["EnemyDefeated_MarksTown_Cave"]["MarksMountain19"] = "0";
            save["EnemyDefeated_MarksTown_Cave"]["MarksMountain26"] = "0";
            save["EnemyDefeated_MarksTown_Cave"]["MarksMountain9"] = "0";
            save["EnemyDefeated_MarksTown_Cave"]["MarksMountain4"] = "0";
            save["EnemyDefeated_MarksTown_Cave"]["Room10"] = "0";
            save["EnemyDefeated_MarksTown_Cave"]["MarksMountain32"] = "0";
            save["EnemyDefeated_MarksTown_Cave"]["MarksMountain41"] = "0";
            save["EnemyDefeated_MarksTown_Cave"]["Room11"] = "0";
            MessageBox.Show("Reset encounters for Mt. Town Cave!");
        }

        private void Enemies_Vella_Click(object sender, EventArgs e)
        {
            save["EnemyDefeated_DngnThreePianoKeyHall_Scene"]["MarksMountain1"] = "0";
            save["EnemyDefeated_DngnThreePianoKeyHall_Scene"]["RadioMountain2"] = "0";
            save["EnemyDefeated_DngnThreePianoKeyHall_Scene"]["VellaDngnFoe5"] = "0";
            save["EnemyDefeated_DngnThreePianoKeyHall_Scene"]["VellaDngnFoe6"] = "0";
            save["EnemyDefeated_DungeonThreeVellasMind_Scene"]["VellaDngnFoe1"] = "0";
            save["EnemyDefeated_DungeonThreeVellasMind_Scene"]["VellaDngnFoe0"] = "0";
            save["EnemyDefeated_DngnThreePuzzleRoomsNeon"]["VellasDngNeon8"] = "0";
            save["EnemyDefeated_DngnThreePuzzleRoomsNeon"]["Mimic"] = "0";
            save["EnemyDefeated_DngnThreePuzzleRoomsNeon"]["VellasDngNeon7"] = "0";
            save["EnemyDefeated_DngnThree_SammyKitchen_Scene"]["VellasDngKitchen2"] = "0";
            MessageBox.Show("Reset encounters for The Mind of Vella Wilde!");
        }

        private void Enemies_Essentia_Click(object sender, EventArgs e)
        {
            save["EnemyDefeated_Dungeon4NESHorrorScene"]["EssntDngnFoe5"] = "0";
            save["EnemyDefeated_Dungeon4NESHorrorScene"]["R3EssntDngnFoe7"] = "0";
            save["EnemyDefeated_Dungeon4NESHorrorScene"]["R3EssntDngnFoe2"] = "0";
            save["EnemyDefeated_Dungeon4NESHorrorScene"]["KeyGhostInDungeon4"] = "0";
            save["EnemyDefeated_Dungeon4NESHorrorScene"]["DrkEssntDngnFoe4"] = "0";
            save["EnemyDefeated_Dungeon4NESHorrorScene"]["DrkEssntDngnFoe8"] = "0";
            save["EnemyDefeated_Dungeon4NESHorrorScene"]["DrkEssntDngnFoe5"] = "0";
            save["EnemyDefeated_Dungeon4NESHorrorScene"]["R7EssntDngnFoe6"] = "0";
            save["EnemyDefeated_Dungeon4NESHorrorScene"]["R14EssntDngnFoe0"] = "0";
            save["EnemyDefeated_Dungeon4NESHorrorScene"]["R14EssntDngnFoe7"] = "0";
            save["EnemyDefeated_Dungeon4NES_IansPuzzles"]["Dungeon4_14"] = "0";
            save["EnemyDefeated_Dungeon4NES_IansPuzzles"]["Dungeon4_7"] = "0";
            save["EnemyDefeated_Dungeon4NES_IansPuzzles"]["Dungeon4_8"] = "0";
            save["EnemyDefeated_Dungeon4NES_IansPuzzles"]["Dungeon4_13"] = "0";
            save["EnemyDefeated_Dungeon4NES_IansPuzzles"]["Dungeon4_12"] = "0";
            save["EnemyDefeated_Dungeon4NES_IansPuzzles"]["Mimic"] = "0";
            MessageBox.Show("Reset encounters for The Mind of The Essentia 2000");
        }

        private void Enemies_MonsterDens_Click(object sender, EventArgs e)
        {
            save["EnemyDefeated_MonsterDenOne"]["AfterDngnOnTraining1"] = "0";
            save["EnemyDefeated_MonsterDenOne"]["OneSkull3"] = "0";
            save["EnemyDefeated_MonsterDenOne"]["AfterDngnOnTraining1_xrs"] = "0";
            save["EnemyDefeated_MonsterDenOne"]["MonsterDenTwo2"] = "0";
            save["EnemyDefeated_MonsterDenOne"]["MonsterDenTwo1"] = "0";
            save["EnemyDefeated_MonsterDenOne"]["MonsterDenTwo3"] = "0";
            save["EnemyDefeated_MonsterDenOne"]["MonsterDenThreG4"] = "0";
            save["EnemyDefeated_MonsterDenOne"]["EnemDenEleven0"] = "0";
            save["EnemyDefeated_MonsterDenOne"]["ElevenDen2"] = "0";
            save["EnemyDefeated_MonsterDenOne"]["ElevenDen3"] = "0";
            save["EnemyDefeated_MonsterDenOne"]["ElevenDen1"] = "0";
            save["EnemyDefeated_MonsterDenOne"]["MonsterDenTwo4"] = "0";
            save["EnemyDefeated_MonsterDenOne"]["MonsterDenTwo0"] = "0";
            save["EnemyDefeated_MonsterDenOne"]["MonsterDenThrexx0"] = "0";
            save["EnemyDefeated_MonsterDenOne"]["MonsterDenThreG2"] = "0";
            save["EnemyDefeated_MonsterDenOne"]["MonsterDenThreG1"] = "0";
            save["EnemyDefeated_MonsterDenOne"]["MonsterDenThreG3"] = "0";
            save["EnemyDefeated_MonsterDenOne"]["MonsterDenThrexx3"] = "0";
            save["EnemyDefeated_MonsterDenOne"]["MonsterDenThrexx2"] = "0";
            save["EnemyDefeated_MonsterDenOne"]["MonsterDenThrexx1"] = "0";
            save["EnemyDefeated_MonsterDenOne"]["MotLevel10Nmotmot"] = "0";
            save["EnemyDefeated_MonsterDenOne"]["ElevenDen0"] = "0";
            save["EnemyDefeated_MonsterDenOne"]["Den9En2"] = "0";
            save["EnemyDefeated_MonsterDenOne"]["Den9En0"] = "0";
            save["EnemyDefeated_MonsterDenOne"]["Den9En1"] = "0";
            save["EnemyDefeated_MonsterDenOne"]["Den9En3"] = "0";
            save["EnemyDefeated_MonsterDenOne"]["DEn8En3"] = "0";
            save["EnemyDefeated_MonsterDenOne"]["DEn8En2"] = "0";
            save["EnemyDefeated_MonsterDenOne"]["DEn8En1"] = "0";
            save["EnemyDefeated_MonsterDenOne"]["DEn8En0"] = "0";
            save["EnemyDefeated_MonsterDenOne"]["MnstrDnSeven"] = "0";
            save["EnemyDefeated_MonsterDenOne"]["MnstrDnSeven1"] = "0";
            save["EnemyDefeated_MonsterDenOne"]["MnstrDnSeven2"] = "0";
            save["EnemyDefeated_MonsterDenOne"]["MnstrDnSeven3"] = "0";
            save["EnemyDefeated_MonsterDenOne"]["MnstrDnSeven4"] = "0";
            save["EnemyDefeated_MonsterDenOne"]["MnstrDnSeven6554"] = "0";
            save["EnemyDefeated_MonsterDenOne"]["MnstDenFive0DD0"] = "0";
            save["EnemyDefeated_MonsterDenOne"]["MnstDenFive0DD1"] = "0";
            save["EnemyDefeated_MonsterDenOne"]["MnstDenFive0DD2"] = "0";
            MessageBox.Show("Reset encounters for Monster Dens!");
        }

        private void Enemies_Overworld_Click(object sender, EventArgs e)
        {
            save["OverworldEnemies"]["defeated"] = "0";
            MessageBox.Show("Reset encounters for this chapter's overworld!");
        }

        private void ResetWhistle_Click(object sender, EventArgs e)
        {
            save["EnemyDefeated_EastonUniversity"]["HiddenMonster"] = "0";
            save["NewFranktonScene.Group"]["MonsterWhistlePlayed11"] = "0";
            save["EnemyDefeated_NewFranktonScene"]["HiddenMonster"] = "0";
            save["FlagTown_Beach.Group"]["MonsterWhistlePlayed11"] = "0";
            save["EnemyDefeated_FlagTown_Beach"]["HiddenMonster"] = "0";
            MessageBox.Show("Reset Monster Whistle encounters!");
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveSaveData();
            SaveFileDialog open2 = new SaveFileDialog();
            open2.Filter = "YIIK Save INIs|*.txt";
            if (open2.ShowDialog() == DialogResult.OK)
            {
                //do stuff here, open.FileName is the full path of the selected file
                new FileIniDataParser().WriteFile(open2.FileName, save);
            }
        }

        private void AddToInv_Click(object sender, EventArgs e)
        {
            save["InventoryContents"][ItemNameBox.Text] += Convert.ToString(ItemCountBox.Value);
            ItemList();
        }

    }
}
