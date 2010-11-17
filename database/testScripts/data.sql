
  INSERT INTO [TaskMan].[dbo].[User]
  ([Login], [Password])
  SELECT
  'Andrzej', 'test'
  UNION ALL
  SELECT
  'Krzysiek', 'test'
  
  GO
  
  
  INSERT INTO [TaskMan].[dbo].[Task]
          ( [AuthorId] ,
            [Title] ,
            [Content] ,
            [RealisationDate] ,
            [Priority]
          )
  VALUES  ( 1 , -- AuthorId - int
            'Test title' , -- Title - nvarchar(200)
            'Test content' , -- Content - nvarchar(max)
            '2010-12-31 00:00:00' , -- RealisationDate - datetime2
            1  -- Priority - int
          )
          
  
  GO
          
          
          
  INSERT INTO [TaskMan].[dbo].UsersTasks
          ( UserId, TaskId )
  VALUES  ( 1, -- UserId - int
            1  -- TaskId - int
            )
            
            INSERT INTO [TaskMan].[dbo].UsersTasks
          ( UserId, TaskId )
  VALUES  ( 2, -- UserId - int
            1  -- TaskId - int
            )