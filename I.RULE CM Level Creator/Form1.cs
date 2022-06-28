namespace I.RULE_CM_Level_Creator
{
    public partial class Form1 : Form
    {
        String levelName = "Unnamed Level";
        String levelDescription = "";
        String levelNameColor = "";
        String levelDescriptionColor = "";
        double levelHeartFallSpeed = 1;
        int levelHeartValue = 50;
        double levelHeartSize = 1;
        int levelHeartTimer = 0;
        int levelStartingHearts = 50;
        int levelHeartsCap = 9999;
        int levelWaveAmount = 10;
        List<int> levelBigWaves = new List<int>();
        bool levelDrawWaveBorder = true;
        bool levelDrawFlags = true;
        bool levelDrawWaveBar = true;
        double levelTimerSpeed = 0.5;
        int levelSpawnDelay = -115;
        String levelTimerSpeedAltCondition = "less";
        int levelEnemiesForAltSpeed = 1;
        int levelTimerSpeedAlt = 1;
        int levelDefaultTimerAfterWave = -115;
        int levelIntensity = 0;
        double levelIntensityChangeMultiplyer = 1;
        String levelBackground = "lvl1";
        String levelMusic1 = "mus_ch1";
        String levelMusic2 = "mus_ch1_layer";
        int levelDrawTimer = 1; //true|false
        int levelCampaignLocked = -1; // -1|1
        int levelHiddenUntilUnlocked = 0;
        int levelSpikeBabyDoesntBreakPoop = 0;
        int levelDisableCHADScaling = 0; // 0|1 
        int levelBobsBrainExtraHealth = 0;
        int levelBobsBrainExplodeUponDeath = 0; // 0|1  checkbox: Killed only by self-descrution? Y/N 
        int levelBobsBrainNoSound = 1; // 0|1  checkbox: Play Bob's Brain growing sound? Y/N
        int levelFrozenSpriteCap = 2;
        int defaultIcePoopDontConvertPoop = 0; // 0|1
        int defaultIcePoopDontFreezeEnemies = 0; // 0|1
        int defaultIcePoopFreezePower = 60;
        double defaultIcePoopFreezePowerMult = 1;
        int levelFlyDontBuzzEarly = 0;
        double levelMaxBabies = 4;
        int levelDisableCoinHUD = 1; //checkbox: Enable coin HUD? Y/N
        int levelMulliboomDefaultExplosionBabyDamage = 2000;
        int levelMulliboomDefaultExplosionTileDamage = 2000;
        //other conditions to end level
        int levelConditionEndWithHearts; //chechbox: Have at least X hearts at end of the level
        int levelConditionCollectTotalHearts; //checkbox: Collect X hearts during level
        int levelConditionMaxTotalHearts;
        int levelConditionBabiesKilled; //checkbox: Don't let X or more babies  to be killed (Self-destructing, instant-use and shovelled babies count as dead as well)
        int levelConditionMaxBabiesOnScreen;
        List<String> customSoundFiles = new List<string>();




        //accepted values
        String[] levelTimerSpeedAltConditionAV = { "less", "more" };
        String[] levelBackgroundAV = { "lvl1", "lvl2", "lvl3", "megaPlum", "ragdoll", "middleHorn" };

        public Form1()
        {
            InitializeComponent();
            levelBigWaves.Add(10);
            customSoundFiles.Add("");
            customSoundFiles.Add("");
            customSoundFiles.Add("");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            colorDialog2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (levelNameTextBox.Text != "")
            {
                levelName = levelNameTextBox.Text;
            }
            if (levelDescriptionTextBox.Text != "")
            {
                levelDescription = levelDescriptionTextBox.Text;
            }
            levelNameColor = colorDialog1.Color.ToString();
            levelDescriptionColor = colorDialog2.Color.ToString();

            MessageBox.Show("Level saved!");
            Environment.Exit(0);
        }

        private Boolean isInArray(String[] array, String testedValue)
        {
            Boolean isAnElement = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (testedValue == array[i])
                {
                    isAnElement = true;
                }
            }
            return isAnElement;
        }
    }
}