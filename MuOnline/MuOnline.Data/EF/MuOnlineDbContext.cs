using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MuOnline.Database.Entities.Entites;
using MuOnline.Database.Extensions;

namespace MuOnline.Database.EF
{
    public partial class MuOnlineDbContext : IdentityDbContext<AppUser, AppRole, Guid>
    {
        public MuOnlineDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("Latin1_General_CI_AS");

            modelBuilder.Entity<AccountCharacter>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("AccountCharacter");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GameId1)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GameID1");

                entity.Property(e => e.GameId2)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GameID2");

                entity.Property(e => e.GameId3)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GameID3");

                entity.Property(e => e.GameId4)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GameID4");

                entity.Property(e => e.GameId5)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GameID5");

                entity.Property(e => e.GameIdc)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GameIDC");

                entity.Property(e => e.MoveCnt).HasDefaultValueSql("((0))");

                entity.Property(e => e.Number).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<CashLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CashLog");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.SentDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserId)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<CashShopDatum>(entity =>
            {
                entity.HasKey(e => e.AccountId)
                    .HasName("PK_TempCashShop");

                entity.Property(e => e.AccountId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AccountID");

                entity.Property(e => e.WcoinC).HasColumnName("WCoinC");

                entity.Property(e => e.WcoinP).HasColumnName("WCoinP");
            });

            modelBuilder.Entity<CashShopInventory>(entity =>
            {
                entity.HasKey(e => e.BaseItemCode);

                entity.ToTable("CashShopInventory");

                entity.Property(e => e.AccountId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AccountID");

                entity.Property(e => e.GiftName)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GiftText)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CashShopPeriodicItem>(entity =>
            {
                entity.HasKey(e => e.ItemSerial);

                entity.ToTable("CashShopPeriodicItem");

                entity.Property(e => e.ItemSerial).ValueGeneratedNever();
            });

            modelBuilder.Entity<Character>(entity =>
            {
                entity.HasKey(e => e.Name)
                    .IsClustered(false);

                entity.ToTable("Character");

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AccountId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AccountID");

                entity.Property(e => e.BlocExpire)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Bloc_Expire");

                entity.Property(e => e.Bp).HasColumnName("BP");

                entity.Property(e => e.CLevel)
                    .HasColumnName("cLevel")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ChatLimitTime).HasDefaultValueSql("((0))");

                entity.Property(e => e.CtlCode).HasDefaultValueSql("((0))");

                entity.Property(e => e.DbVersion).HasDefaultValueSql("((0))");

                entity.Property(e => e.EffectList).HasMaxLength(208);

                entity.Property(e => e.Experience).HasDefaultValueSql("((0))");

                entity.Property(e => e.FruitPoint).HasDefaultValueSql("((0))");

                entity.Property(e => e.Inventory).HasMaxLength(3776);

                entity.Property(e => e.Ldate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("LDate");

                entity.Property(e => e.Leadership).HasDefaultValueSql("((0))");

                entity.Property(e => e.LevelUpPoint).HasDefaultValueSql("((0))");

                entity.Property(e => e.Lvtuchan).HasColumnName("lvtuchan");

                entity.Property(e => e.MagicList).HasMaxLength(180);

                entity.Property(e => e.MapDir).HasDefaultValueSql("((0))");

                entity.Property(e => e.MaxBp).HasColumnName("MaxBP");

                entity.Property(e => e.Mdate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("MDate");

                entity.Property(e => e.Money).HasDefaultValueSql("((0))");

                entity.Property(e => e.PkCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.PkLevel).HasDefaultValueSql("((3))");

                entity.Property(e => e.PkTime).HasDefaultValueSql("((0))");

                entity.Property(e => e.Quest)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Rcrit).HasColumnName("rcrit");

                entity.Property(e => e.Rdef).HasColumnName("rdef");

                entity.Property(e => e.Rdmg).HasColumnName("rdmg");

                entity.Property(e => e.Rdouble).HasColumnName("rdouble");

                entity.Property(e => e.ResetsTime).HasColumnName("Resets_Time");

                entity.Property(e => e.Rexc).HasColumnName("rexc");

                entity.Property(e => e.Rlife).HasColumnName("rlife");

                entity.Property(e => e.Rmana).HasColumnName("rmana");
            });

            modelBuilder.Entity<CustomAttack>(entity =>
            {
                entity.HasKey(e => e.Name);

                entity.ToTable("CustomAttack");

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CustomGift>(entity =>
            {
                entity.HasKey(e => e.AccountId);

                entity.ToTable("CustomGift");

                entity.Property(e => e.AccountId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AccountID");
            });

            modelBuilder.Entity<CustomNpcQuest>(entity =>
            {
                entity.HasKey(e => new { e.Name, e.Quest });

                entity.ToTable("CustomNpcQuest");

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.NameNavigation)
                    .WithMany(p => p.CustomNpcQuests)
                    .HasForeignKey(d => d.Name)
                    .HasConstraintName("FK_CustomNpcQuest_Character");
            });

            modelBuilder.Entity<CustomQuest>(entity =>
            {
                entity.HasKey(e => e.Name);

                entity.ToTable("CustomQuest");

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.NameNavigation)
                    .WithOne(p => p.CustomQuest)
                    .HasForeignKey<CustomQuest>(d => d.Name)
                    .HasConstraintName("FK_CustomQuest_Character");
            });

            modelBuilder.Entity<DefaultClassType>(entity =>
            {
                entity.HasKey(e => e.Class);

                entity.ToTable("DefaultClassType");

                entity.Property(e => e.EffectList).HasMaxLength(208);

                entity.Property(e => e.Inventory).HasMaxLength(3776);

                entity.Property(e => e.Leadership).HasDefaultValueSql("((0))");

                entity.Property(e => e.Level).HasDefaultValueSql("((0))");

                entity.Property(e => e.LevelUpPoint).HasDefaultValueSql("((0))");

                entity.Property(e => e.MagicList).HasMaxLength(180);

                entity.Property(e => e.Quest).HasMaxLength(50);
            });

            modelBuilder.Entity<EventLeoTheHelper>(entity =>
            {
                entity.HasKey(e => e.Name);

                entity.ToTable("EventLeoTheHelper");

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EventSantaClau>(entity =>
            {
                entity.HasKey(e => e.Name);

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ExtWarehouse>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ExtWarehouse");

                entity.Property(e => e.AccountId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AccountID");

                entity.Property(e => e.Items).HasMaxLength(3840);
            });

            modelBuilder.Entity<GameServerInfo>(entity =>
            {
                entity.HasKey(e => e.Number)
                    .IsClustered(false);

                entity.ToTable("GameServerInfo");

                entity.Property(e => e.Number).ValueGeneratedNever();

                entity.Property(e => e.ZenCount).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<GensDuprian>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Gens_Duprian");

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GensRank>(entity =>
            {
                entity.HasKey(e => e.Name);

                entity.ToTable("Gens_Rank");

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GensReward>(entity =>
            {
                entity.HasKey(e => e.Name);

                entity.ToTable("Gens_Reward");

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GensVarnert>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Gens_Varnert");

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GhrsTop1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GHRS_top1");

                entity.Property(e => e.Resetcount).HasColumnName("resetcount");

                entity.Property(e => e.Time).HasColumnName("time");
            });

            modelBuilder.Entity<Guild>(entity =>
            {
                entity.HasKey(e => e.GName);

                entity.ToTable("Guild");

                entity.Property(e => e.GName)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("G_Name");

                entity.Property(e => e.GCount).HasColumnName("G_Count");

                entity.Property(e => e.GMark)
                    .HasMaxLength(32)
                    .HasColumnName("G_Mark");

                entity.Property(e => e.GMaster)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("G_Master");

                entity.Property(e => e.GNotice)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("G_Notice");

                entity.Property(e => e.GRival).HasColumnName("G_Rival");

                entity.Property(e => e.GScore)
                    .HasColumnName("G_Score")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.GType).HasColumnName("G_Type");

                entity.Property(e => e.GUnion).HasColumnName("G_Union");

                entity.Property(e => e.MemberCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.Number).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<GuildMember>(entity =>
            {
                entity.HasKey(e => e.Name);

                entity.ToTable("GuildMember");

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GLevel).HasColumnName("G_Level");

                entity.Property(e => e.GName)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("G_Name");

                entity.Property(e => e.GStatus).HasColumnName("G_Status");
            });

            modelBuilder.Entity<HelperDatum>(entity =>
            {
                entity.HasKey(e => e.Name);

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Data)
                    .HasMaxLength(256)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ItemLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ItemLog");

                entity.Property(e => e.Acc)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.I380).HasColumnName("i380");

                entity.Property(e => e.IExt)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("iExt");

                entity.Property(e => e.IJh).HasColumnName("iJh");

                entity.Property(e => e.ILuck).HasColumnName("iLuck");

                entity.Property(e => e.ILvl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("iLvl");

                entity.Property(e => e.IName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("iName");

                entity.Property(e => e.ISet).HasColumnName("iSet");

                entity.Property(e => e.ISkill).HasColumnName("iSkill");

                entity.Property(e => e.ItemCode).HasMaxLength(32);

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SentDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Seq)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SEQ");

                entity.Property(e => e.Sn).HasColumnName("SN");
            });

            modelBuilder.Entity<LogCredito>(entity =>
            {
                entity.HasKey(e => e.IdCreditos);

                entity.ToTable("LOG_CREDITOS");

                entity.Property(e => e.IdCreditos).HasColumnName("id_creditos");

                entity.Property(e => e.Data)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("data")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ip)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("ip")
                    .IsFixedLength();

                entity.Property(e => e.Login)
                    .HasMaxLength(10)
                    .HasColumnName("login");

                entity.Property(e => e.Tipo).HasColumnName("tipo");

                entity.Property(e => e.Valor).HasColumnName("valor");
            });

            modelBuilder.Entity<LuckyCoin>(entity =>
            {
                entity.HasKey(e => e.AccountId);

                entity.ToTable("LuckyCoin");

                entity.Property(e => e.AccountId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AccountID");

                entity.Property(e => e.LuckyCoin1).HasColumnName("LuckyCoin");
            });

            modelBuilder.Entity<LuckyItem>(entity =>
            {
                entity.HasKey(e => e.ItemSerial);

                entity.ToTable("LuckyItem");

                entity.Property(e => e.ItemSerial).ValueGeneratedNever();
            });

            modelBuilder.Entity<Marry>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Marry");

                entity.Property(e => e.Character)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.MarriedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MarryCharacter)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasterSkillTree>(entity =>
            {
                entity.HasKey(e => e.Name);

                entity.ToTable("MasterSkillTree");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MasterSkill).HasMaxLength(360);
            });

            modelBuilder.Entity<MembInfo>(entity =>
            {
                entity.HasKey(e => e.MembGuid)
                    .HasName("PK_MEMB_INFO_1")
                    .IsClustered(false);

                entity.ToTable("MEMB_INFO");

                entity.Property(e => e.MembGuid).HasColumnName("memb_guid");

                entity.Property(e => e.AccountExpireDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddrDeta)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("addr_deta");

                entity.Property(e => e.AddrInfo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("addr_info");

                entity.Property(e => e.ApplDays)
                    .HasColumnType("datetime")
                    .HasColumnName("appl_days");

                entity.Property(e => e.BlocCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("bloc_code")
                    .IsFixedLength();

                entity.Property(e => e.BlocExpire)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Bloc_Expire");

                entity.Property(e => e.Ctl1Code)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ctl1_code")
                    .IsFixedLength();

                entity.Property(e => e.FpasAnsw)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fpas_answ");

                entity.Property(e => e.FpasQues)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fpas_ques");

                entity.Property(e => e.JobCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("job__code")
                    .IsFixedLength();

                entity.Property(e => e.MailAddr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mail_addr");

                entity.Property(e => e.MailChek)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mail_chek")
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.MembId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("memb___id");

                entity.Property(e => e.MembName)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("memb_name");

                entity.Property(e => e.MembPwd)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("memb__pwd");

                entity.Property(e => e.ModiDays)
                    .HasColumnType("datetime")
                    .HasColumnName("modi_days");

                entity.Property(e => e.OutDays)
                    .HasColumnType("datetime")
                    .HasColumnName("out__days");

                entity.Property(e => e.PhonNumb)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("phon_numb");

                entity.Property(e => e.PostCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("post_code")
                    .IsFixedLength();

                entity.Property(e => e.SnoNumb)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("sno__numb")
                    .IsFixedLength();

                entity.Property(e => e.TelNumb)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("tel__numb");

                entity.Property(e => e.TrueDays)
                    .HasColumnType("datetime")
                    .HasColumnName("true_days");
            });

            modelBuilder.Entity<MembStat>(entity =>
            {
                entity.HasKey(e => e.MembId);

                entity.ToTable("MEMB_STAT");

                entity.Property(e => e.MembId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("memb___id");

                entity.Property(e => e.ConnectTm)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("ConnectTM");

                entity.Property(e => e.DisConnectTm)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("DisConnectTM");

                entity.Property(e => e.Ip)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("IP");

                entity.Property(e => e.OnlineHours).HasDefaultValueSql("((0))");

                entity.Property(e => e.ServerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MkServer>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MK_Server");

                entity.Property(e => e.RecordeOn).HasColumnName("recorde_on");

                entity.Property(e => e.ReiDoMk).HasColumnName("rei_do_mk");
            });

            modelBuilder.Entity<MuCastleDatum>(entity =>
            {
                entity.HasKey(e => e.MapSvrGroup);

                entity.ToTable("MuCastle_DATA");

                entity.Property(e => e.MapSvrGroup)
                    .ValueGeneratedNever()
                    .HasColumnName("MAP_SVR_GROUP");

                entity.Property(e => e.CastleOccupy).HasColumnName("CASTLE_OCCUPY");

                entity.Property(e => e.Money)
                    .HasColumnType("money")
                    .HasColumnName("MONEY");

                entity.Property(e => e.OwnerGuild)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("OWNER_GUILD");

                entity.Property(e => e.SiegeEndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("SIEGE_END_DATE");

                entity.Property(e => e.SiegeEnded).HasColumnName("SIEGE_ENDED");

                entity.Property(e => e.SiegeGuildlistSetted).HasColumnName("SIEGE_GUILDLIST_SETTED");

                entity.Property(e => e.SiegeStartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("SIEGE_START_DATE");

                entity.Property(e => e.TaxHuntZone).HasColumnName("TAX_HUNT_ZONE");

                entity.Property(e => e.TaxRateChaos).HasColumnName("TAX_RATE_CHAOS");

                entity.Property(e => e.TaxRateStore).HasColumnName("TAX_RATE_STORE");
            });

            modelBuilder.Entity<MuCastleMoneyStatistic>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MuCastle_MONEY_STATISTICS");

                entity.Property(e => e.LogDate)
                    .HasColumnType("datetime")
                    .HasColumnName("LOG_DATE");

                entity.Property(e => e.MapSvrGroup).HasColumnName("MAP_SVR_GROUP");

                entity.Property(e => e.MoneyChange)
                    .HasColumnType("money")
                    .HasColumnName("MONEY_CHANGE");
            });

            modelBuilder.Entity<MuCastleNpc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MuCastle_NPC");

                entity.HasIndex(e => new { e.MapSvrGroup, e.NpcNumber, e.NpcIndex }, "IX_NPC_SUBKEY")
                    .IsUnique();

                entity.Property(e => e.MapSvrGroup).HasColumnName("MAP_SVR_GROUP");

                entity.Property(e => e.NpcCreatedate)
                    .HasColumnType("datetime")
                    .HasColumnName("NPC_CREATEDATE");

                entity.Property(e => e.NpcDfLevel).HasColumnName("NPC_DF_LEVEL");

                entity.Property(e => e.NpcDir).HasColumnName("NPC_DIR");

                entity.Property(e => e.NpcHp).HasColumnName("NPC_HP");

                entity.Property(e => e.NpcIndex).HasColumnName("NPC_INDEX");

                entity.Property(e => e.NpcMaxhp).HasColumnName("NPC_MAXHP");

                entity.Property(e => e.NpcNumber).HasColumnName("NPC_NUMBER");

                entity.Property(e => e.NpcRgLevel).HasColumnName("NPC_RG_LEVEL");

                entity.Property(e => e.NpcX).HasColumnName("NPC_X");

                entity.Property(e => e.NpcY).HasColumnName("NPC_Y");
            });

            modelBuilder.Entity<MuCastleRegSiege>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MuCastle_REG_SIEGE");

                entity.HasIndex(e => new { e.MapSvrGroup, e.RegSiegeGuild }, "IX_ATTACK_GUILD_SUBKEY")
                    .IsUnique();

                entity.Property(e => e.IsGiveup).HasColumnName("IS_GIVEUP");

                entity.Property(e => e.MapSvrGroup).HasColumnName("MAP_SVR_GROUP");

                entity.Property(e => e.RegMarks).HasColumnName("REG_MARKS");

                entity.Property(e => e.RegSiegeGuild)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("REG_SIEGE_GUILD");

                entity.Property(e => e.SeqNum).HasColumnName("SEQ_NUM");
            });

            modelBuilder.Entity<MuCastleSiegeGuildlist>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MuCastle_SIEGE_GUILDLIST");

                entity.Property(e => e.GuildId).HasColumnName("GUILD_ID");

                entity.Property(e => e.GuildInvolved).HasColumnName("GUILD_INVOLVED");

                entity.Property(e => e.GuildName)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("GUILD_NAME");

                entity.Property(e => e.GuildScore).HasColumnName("GUILD_SCORE");

                entity.Property(e => e.MapSvrGroup).HasColumnName("MAP_SVR_GROUP");
            });

            modelBuilder.Entity<OptionDatum>(entity =>
            {
                entity.HasKey(e => e.Name);

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Qwerlevel).HasColumnName("QWERLevel");

                entity.Property(e => e.SkillKey)
                    .HasMaxLength(20)
                    .IsFixedLength();
            });

            modelBuilder.Entity<QuestKillCount>(entity =>
            {
                entity.HasKey(e => e.Name);

                entity.ToTable("QuestKillCount");

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<QuestWorld>(entity =>
            {
                entity.HasKey(e => e.Name);

                entity.ToTable("QuestWorld");

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.QuestWorldList).HasMaxLength(400);
            });

            modelBuilder.Entity<RankingBloodCastle>(entity =>
            {
                entity.HasKey(e => e.Name);

                entity.ToTable("RankingBloodCastle");

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ScoreSemanal).HasColumnName("Score_semanal");
            });

            modelBuilder.Entity<RankingChaosCastle>(entity =>
            {
                entity.HasKey(e => e.Name);

                entity.ToTable("RankingChaosCastle");

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ScoreSemanal).HasColumnName("Score_semanal");
            });

            modelBuilder.Entity<RankingDevilSquare>(entity =>
            {
                entity.HasKey(e => e.Name);

                entity.ToTable("RankingDevilSquare");

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ScoreSemanal).HasColumnName("Score_semanal");
            });

            modelBuilder.Entity<RankingDuel>(entity =>
            {
                entity.HasKey(e => e.Name);

                entity.ToTable("RankingDuel");

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.WinScoreSemanal).HasColumnName("WinScore_semanal");
            });

            modelBuilder.Entity<RankingIllusionTemple>(entity =>
            {
                entity.HasKey(e => e.Name);

                entity.ToTable("RankingIllusionTemple");

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RankingKingGuild>(entity =>
            {
                entity.HasKey(e => e.Name);

                entity.ToTable("RankingKingGuild");

                entity.Property(e => e.Name)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ScoreSemanal).HasColumnName("Score_semanal");
            });

            modelBuilder.Entity<RankingKingPlayer>(entity =>
            {
                entity.HasKey(e => e.Name);

                entity.ToTable("RankingKingPlayer");

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ScoreSemanal).HasColumnName("Score_semanal");
            });

            modelBuilder.Entity<RankingTvT>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RankingTvT");

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TCguid>(entity =>
            {
                entity.HasKey(e => e.Guid);

                entity.ToTable("T_CGuid");

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TFriendList>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_FriendList");

                entity.Property(e => e.Del).HasDefaultValueSql("((0))");

                entity.Property(e => e.FriendName)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Guid).HasColumnName("GUID");
            });

            modelBuilder.Entity<TFriendMail>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.MemoIndex })
                    .HasName("PK_T_FriendMemo");

                entity.ToTable("T_FriendMail");

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.MemoIndex).HasDefaultValueSql("((10))");

                entity.Property(e => e.Act).HasDefaultValueSql("((0))");

                entity.Property(e => e.BRead).HasColumnName("bRead");

                entity.Property(e => e.Dir).HasDefaultValueSql("((0))");

                entity.Property(e => e.FriendName)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Memo).HasMaxLength(1000);

                entity.Property(e => e.Photo)
                    .HasMaxLength(18)
                    .IsFixedLength();

                entity.Property(e => e.Subject)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("wDate")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TFriendMain>(entity =>
            {
                entity.HasKey(e => e.Guid);

                entity.ToTable("T_FriendMain");

                entity.Property(e => e.Guid)
                    .ValueGeneratedNever()
                    .HasColumnName("GUID");

                entity.Property(e => e.MemoCount).HasDefaultValueSql("((10))");

                entity.Property(e => e.MemoTotal).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TPetItemInfo>(entity =>
            {
                entity.HasKey(e => e.ItemSerial)
                    .HasName("PK_T_Pet_Info");

                entity.ToTable("T_PetItem_Info");

                entity.Property(e => e.ItemSerial).ValueGeneratedNever();

                entity.Property(e => e.PetExp)
                    .HasColumnName("Pet_Exp")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PetLevel)
                    .HasColumnName("Pet_Level")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<TWaitFriend>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_WaitFriend");

                entity.Property(e => e.FriendName)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Guid).HasColumnName("GUID");
            });

            modelBuilder.Entity<Warehouse>(entity =>
            {
                entity.HasKey(e => e.AccountId);

                entity.ToTable("warehouse");

                entity.Property(e => e.AccountId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AccountID");

                entity.Property(e => e.DbVersion).HasDefaultValueSql("((0))");

                entity.Property(e => e.EndUseDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Items).HasMaxLength(3840);

                entity.Property(e => e.Money).HasDefaultValueSql("((0))");

                entity.Property(e => e.Pw)
                    .HasColumnName("pw")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<WarehouseGuild>(entity =>
            {
                entity.HasKey(e => e.Guild)
                    .HasName("PK_warehouseguild");

                entity.ToTable("WarehouseGuild");

                entity.Property(e => e.Guild)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EndUseDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Items).HasMaxLength(3840);

                entity.Property(e => e.Pw).HasColumnName("pw");
            });

            modelBuilder.Entity<WzCwInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("WZ_CW_INFO");

                entity.Property(e => e.CrywolfOccufy).HasColumnName("CRYWOLF_OCCUFY");

                entity.Property(e => e.CrywolfState).HasColumnName("CRYWOLF_STATE");

                entity.Property(e => e.MapSvrGroup).HasColumnName("MAP_SVR_GROUP");
            });

            modelBuilder.Entity<IdentityUserClaim<Guid>>().ToTable("AppUserClaims");
            modelBuilder.Entity<IdentityUserRole<Guid>>().ToTable("AppUserRoles").HasKey(x => new { x.UserId, x.RoleId });
            modelBuilder.Entity<IdentityUserLogin<Guid>>().ToTable("AppUserLogins").HasKey(x => x.UserId);

            modelBuilder.Entity<IdentityRoleClaim<Guid>>().ToTable("AppRoleClaims");
            modelBuilder.Entity<IdentityUserToken<Guid>>().ToTable("AppUserTokens").HasKey(x => x.UserId);

            modelBuilder.Seed();

            OnModelCreatingPartial(modelBuilder);
        }

        public virtual DbSet<AccountCharacter> AccountCharacters { get; set; } = null!;
        public virtual DbSet<CashLog> CashLogs { get; set; } = null!;
        public virtual DbSet<CashShopDatum> CashShopData { get; set; } = null!;
        public virtual DbSet<CashShopInventory> CashShopInventories { get; set; } = null!;
        public virtual DbSet<CashShopPeriodicItem> CashShopPeriodicItems { get; set; } = null!;
        public virtual DbSet<Character> Characters { get; set; } = null!;
        public virtual DbSet<CustomAttack> CustomAttacks { get; set; } = null!;
        public virtual DbSet<CustomGift> CustomGifts { get; set; } = null!;
        public virtual DbSet<CustomNpcQuest> CustomNpcQuests { get; set; } = null!;
        public virtual DbSet<CustomQuest> CustomQuests { get; set; } = null!;
        public virtual DbSet<DefaultClassType> DefaultClassTypes { get; set; } = null!;
        public virtual DbSet<EventLeoTheHelper> EventLeoTheHelpers { get; set; } = null!;
        public virtual DbSet<EventSantaClau> EventSantaClaus { get; set; } = null!;
        public virtual DbSet<ExtWarehouse> ExtWarehouses { get; set; } = null!;
        public virtual DbSet<GameServerInfo> GameServerInfos { get; set; } = null!;
        public virtual DbSet<GensDuprian> GensDuprians { get; set; } = null!;
        public virtual DbSet<GensRank> GensRanks { get; set; } = null!;
        public virtual DbSet<GensReward> GensRewards { get; set; } = null!;
        public virtual DbSet<GensVarnert> GensVarnerts { get; set; } = null!;
        public virtual DbSet<GhrsTop1> GhrsTop1s { get; set; } = null!;
        public virtual DbSet<Guild> Guilds { get; set; } = null!;
        public virtual DbSet<GuildMember> GuildMembers { get; set; } = null!;
        public virtual DbSet<HelperDatum> HelperData { get; set; } = null!;
        public virtual DbSet<ItemLog> ItemLogs { get; set; } = null!;
        public virtual DbSet<LogCredito> LogCreditos { get; set; } = null!;
        public virtual DbSet<LuckyCoin> LuckyCoins { get; set; } = null!;
        public virtual DbSet<LuckyItem> LuckyItems { get; set; } = null!;
        public virtual DbSet<Marry> Marries { get; set; } = null!;
        public virtual DbSet<MasterSkillTree> MasterSkillTrees { get; set; } = null!;
        public virtual DbSet<MembInfo> MembInfos { get; set; } = null!;
        public virtual DbSet<MembStat> MembStats { get; set; } = null!;
        public virtual DbSet<MkServer> MkServers { get; set; } = null!;
        public virtual DbSet<MuCastleDatum> MuCastleData { get; set; } = null!;
        public virtual DbSet<MuCastleMoneyStatistic> MuCastleMoneyStatistics { get; set; } = null!;
        public virtual DbSet<MuCastleNpc> MuCastleNpcs { get; set; } = null!;
        public virtual DbSet<MuCastleRegSiege> MuCastleRegSieges { get; set; } = null!;
        public virtual DbSet<MuCastleSiegeGuildlist> MuCastleSiegeGuildlists { get; set; } = null!;
        public virtual DbSet<OptionDatum> OptionData { get; set; } = null!;
        public virtual DbSet<QuestKillCount> QuestKillCounts { get; set; } = null!;
        public virtual DbSet<QuestWorld> QuestWorlds { get; set; } = null!;
        public virtual DbSet<RankingBloodCastle> RankingBloodCastles { get; set; } = null!;
        public virtual DbSet<RankingChaosCastle> RankingChaosCastles { get; set; } = null!;
        public virtual DbSet<RankingDevilSquare> RankingDevilSquares { get; set; } = null!;
        public virtual DbSet<RankingDuel> RankingDuels { get; set; } = null!;
        public virtual DbSet<RankingIllusionTemple> RankingIllusionTemples { get; set; } = null!;
        public virtual DbSet<RankingKingGuild> RankingKingGuilds { get; set; } = null!;
        public virtual DbSet<RankingKingPlayer> RankingKingPlayers { get; set; } = null!;
        public virtual DbSet<RankingTvT> RankingTvTs { get; set; } = null!;
        public virtual DbSet<TCguid> TCguids { get; set; } = null!;
        public virtual DbSet<TFriendList> TFriendLists { get; set; } = null!;
        public virtual DbSet<TFriendMail> TFriendMails { get; set; } = null!;
        public virtual DbSet<TFriendMain> TFriendMains { get; set; } = null!;
        public virtual DbSet<TPetItemInfo> TPetItemInfos { get; set; } = null!;
        public virtual DbSet<TWaitFriend> TWaitFriends { get; set; } = null!;
        public virtual DbSet<Warehouse> Warehouses { get; set; } = null!;
        public virtual DbSet<WarehouseGuild> WarehouseGuilds { get; set; } = null!;
        public virtual DbSet<WzCwInfo> WzCwInfos { get; set; } = null!;

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
