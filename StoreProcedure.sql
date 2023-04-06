CREATE PROCEDURE CategorizeTrades
AS
BEGIN
    CREATE TABLE #TradeCategories (
        Category VARCHAR(10) NOT NULL
    );

    INSERT INTO #TradeCategories
        SELECT
            CASE
                WHEN Value < 1000000 AND ClientSector = 'Public' THEN 'LOWRISK'
                WHEN Value >= 1000000 AND ClientSector = 'Public' THEN 'MEDIUMRISK'
                WHEN Value >= 1000000 AND ClientSector = 'Private' THEN 'HIGHRISK'
                ELSE 'UNKNOWN'
            END AS Category
        FROM Trades;

    SELECT * FROM #TradeCategories;
END;