--���Ӧ��
INSERT INTO [dbo].[SystemApplication]([ID],[ApplicationName],[ActivateStatus],[DataStatus],[CreateTime],[CreateUserID],[LastModifiedTime],[LastModifiedUserID])
VALUES (6943288131798388737,'C-BTS',1,1,GETDATE(),1,GETDATE(),1)

--��ӷ���
INSERT INTO [dbo].[SystemLanguageTranslate]([ID],[LanguageCode],[MultiLanguageKey],[TranslateValue],[DataStatus],[CreateTime],[CreateUserID],[LastModifiedTime],[LastModifiedUserID])
VALUES(6943250866002857985,'zh-CN','Role-Production','����',1,GETDATE(),1,GETDATE(),1),
      (6943252225397755906,'zh-CN','Role-Operation','��ά',1,GETDATE(),1,GETDATE(),1),
	  (6943252322525253635,'zh-CN','Role-Admin','����Ա',1,GETDATE(),1,GETDATE(),1),
	  (6943252377122508804,'en-US','Role-Production','Production',1,GETDATE(),1,GETDATE(),1),
      (6943252442264244229,'en-US','Role-Operation','Operation',1,GETDATE(),1,GETDATE(),1),
	  (6943252501341016070,'en-US','Role-Admin','Admin',1,GETDATE(),1,GETDATE(),1)

--��ӽ�ɫ
INSERT INTO [dbo].[SystemRole]([ID],[ApplicationID],[Name],[NameMultiLanguageKey],[ActivateStatus],[EditStatus],[DataStatus],[CreateTime],[CreateUserID],[LastModifiedTime],[LastModifiedUserID])
VALUES(6943289161583906818,6943288131798388737,'����','Role-Production',1,2,1,GETDATE(),1,GETDATE(),1),
      (6943289531777372163,6943288131798388737,'��ά','Role-Operation',1,2,1,GETDATE(),1,GETDATE(),1),
	  (6943289564195147780,6943288131798388737,'����Ա','Role-Admin',1,2,1,GETDATE(),1,GETDATE(),1)