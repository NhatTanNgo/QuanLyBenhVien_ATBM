--TAO POLICY
BEGIN 
    SA_SYSDBA.CREATE_POLICY (
    POLICY_NAME => 'ACCESS_NHANVIEN',
    COLUMN_NAME =>'OLS_NHANVIEN',
    DEFAULT_OPTIONS => 'READ_CONTROL');
END;
/

--TAO THANH PHAN LEVEL
BEGIN
    SA_COMPONENTS.CREATE_LEVEL (
    POLICY_NAME => 'ACCESS_NHANVIEN',
    LEVEL_NUM   => 40,
    SHORT_NAME  => 'QL',
    LONG_NAME   => 'QUAN LY');

    SA_COMPONENTS.CREATE_LEVEL (
    POLICY_NAME => 'ACCESS_NHANVIEN',
    LEVEL_NUM   => 30,
    SHORT_NAME  => 'NV',
    LONG_NAME   => 'NHANVIEN');
END;
/

--TAO THANH PHAN COMPARTNENT
BEGIN 
    SA_COMPONENTS.CREATE_COMPARTMENT (
    POLICY_NAME => 'ACCESS_NHANVIEN',
    COMP_NUM    =>  85, 
    SHORT_NAME  => 'NS',
    LONG_NAME   => 'NHANSU');

    SA_COMPONENTS.CREATE_COMPARTMENT (
    POLICY_NAME => 'ACCESS_NHANVIEN',
    COMP_NUM    => 65, 
    SHORT_NAME  => 'CM',
    LONG_NAME   => 'CHUYENMON');
END;
/

--TAO THANH PHAN GROUP
BEGIN
    SA_COMPONENTS.CREATE_GROUP (
    POLICY_NAME => 'ACCESS_NHANVIEN',
    GROUP_NUM   => 1000,
    SHORT_NAME  => 'CNA',
    LONG_NAME   => 'CHI NHANH A',
    PARENT_NAME => NULL);

    SA_COMPONENTS.CREATE_GROUP (
    POLICY_NAME => 'ACCESS_NHANVIEN',
    GROUP_NUM   => 1100,
    SHORT_NAME  => 'CNB',
    LONG_NAME   => 'CHI NHANH B',
    PARENT_NAME => NULL);
END;
/

--TAO CAC NHAN CHO USER VA DATA
BEGIN 
    SA_LABEL_ADMIN.CREATE_LABEL ( 
    POLICY_NAME => 'ACCESS_NHANVIEN',
    LABEL_TAG   => '2',
    LABEL_VALUE => 'QL'); 
    
    SA_LABEL_ADMIN.CREATE_LABEL ( 
    POLICY_NAME => 'ACCESS_NHANVIEN',
    LABEL_TAG   => '1',
    LABEL_VALUE => 'NV');
END; 
/

--GAN LEVEL CHO USER
BEGIN
    SA_USER_ADMIN.SET_LEVELS (
    POLICY_NAME=> 'ACCESS_NHANVIEN',
    USER_NAME => 'NVNS',
    MAX_LEVEL => 'NV',
    MIN_LEVEL => 'NV',
    DEF_LEVEL => 'NV',
    ROW_LEVEL => 'NV');
END;
/

--DAT QUYEN CHO USER
BEGIN
    SA_USER_ADMIN.SET_USER_PRIVS (
    POLICY_NAME => 'ACCESS_NHANVIEN',
    USER_NAME   => 'NVNS',
    PRIVILEGES  => 'READ');
END;
/

BEGIN
    SA_USER_ADMIN.SET_USER_LABELS
    (POLICY_NAME    => 'ACCESS_NHANVIEN',
    USER_NAME       => 'NVNS',
    MAX_READ_LABEL  => 'NV');
END;
/
--GAN POLICY LEN BANG NHANVIEN
BEGIN
    SA_POLICY_ADMIN.APPLY_TABLE_POLICY (
    POLICY_NAME     => 'ACCESS_NHANVIEN', 
    SCHEMA_NAME     => 'DBA_QLBV', 
    TABLE_NAME      => 'NHANVIEN', 
    TABLE_OPTIONS   => 'NO_CONTROL');
END;
/

UPDATE NHANVIEN
SET OLS_NHANVIEN = CHAR_TO_LABEL('ACCESS_NHANVIEN','QL')
WHERE MANHANVIEN = 'NV000';





/*BEGIN
    SA_LABEL_ADMIN.CREATE_LABEL
    ('ACCESS_NHANVIEN', 500, 'QL:NS,CM:CNT');
    
    SA_LABEL_ADMIN.CREATE_LABEL
    ('ACCESS_NHANVIEN', 320, 'NV:NS,CM:CN1');
    
    SA_LABEL_ADMIN.CREATE_LABEL
    ('ACCESS_NHANVIEN', 330, 'NV:NS:CN1');
    
    SA_LABEL_ADMIN.CREATE_LABEL
    ('ACCESS_NHANVIEN', 340, 'NV:CM:CN1');   
END;
*/
    

    
    
    
    
    

BEGIN
    SA_LABEL_ADMIN.CREATE_LABEL  --Label cua GD CNB
    ('ACCESS_NHANVIEN', 360, 'QL:NS:CNB');
END;

BEGIN
    SA_LABEL_ADMIN.CREATE_LABEL --LABEL C?A QLNS CNA
    ('ACCESS_NHANVIEN', 300, 'QL:NS,CM:CNA');
END;

BEGIN
    SA_LABEL_ADMIN.CREATE_LABEL --LABEL C?A NVNS CNB
    ('ACCESS_NHANVIEN', 290, 'NV:NS,CM:CNB');
END;