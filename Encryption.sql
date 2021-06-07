--- MA HOA ------
---- NHANVIEN: LUONGCOBAN --------
----           PHUCAP ------------
---- PHIEUKHAMBENH: TRIEUCHUNG ---
----                KETLUANCUABS--


--- ENCRYPTION AND DECRYPTION ----
--MA HOA DU LIEU
CREATE OR REPLACE FUNCTION ENCRYPT_DATA 
(input_string VARCHAR2, key_string VARCHAR2)
RETURN VARCHAR2
--Input string la chuoi can ma hoa
--Key string la chia khoa ma hoa
--Output string la chuoi da ma hoa
AS
    --MA HOA INPUT STRING
    raw_input RAW(128):=  
    UTL_RAW.CAST_TO_RAW(CONVERT(input_string,'AL32UTF8','US7ASCII'));
    
    --TAO KEY
    raw_key RAW(128) :=
    UTL_RAW.CAST_TO_RAW(CONVERT(key_string,'AL32UTF8','US7ASCII'));
    
    --CHUOI RAW SAU KHI MA HOA
    encrypted_raw RAW(2048);
    output_string VARCHAR2(2048);
BEGIN  
    --MA HOA THEO DES_CBC_PKCS5
    encrypted_raw := dbms_crypto.Encrypt(src => raw_input,
                                         typ => DBMS_CRYPTO.DES_CBC_PKCS5,
                                         key => raw_key);
                                         
    output_string := rawtohex(encrypted_raw);
    RETURN output_string;
END;
/

--GIAI MA DU LIEU
CREATE OR REPLACE FUNCTION DECRYPT_DATA 
(input_string VARCHAR2, key_string VARCHAR2)
RETURN VARCHAR2
--Input string la chuoi hex can giai ma
--Key string la chia khoa ma hoa
--Output string la chuoi da giai ma
AS
    --MA HOA INPUT STRING
    raw_input RAW(128):= hextoraw(input_string);
    --TAO KEY
    raw_key RAW(128) :=
    UTL_RAW.CAST_TO_RAW(CONVERT(key_string,'AL32UTF8','US7ASCII'));
    
    --CHUOI RAW SAU KHI MA HOA
    decrypted_raw RAW(2048);
	output_string VARCHAR2 (2048);
BEGIN
    decrypted_raw := dbms_crypto.Decrypt(src => raw_input,
                                         typ => DBMS_CRYPTO.DES_CBC_PKCS5,
                                         key => raw_key);
    output_string :=
    CONVERT(UTL_RAW.CAST_TO_VARCHAR2(decrypted_raw),'US7ASCII','AL32UTF8');
    RETURN output_string;
END;
/

--MA HOA LUONG CO BAN VA PHU CAP KHI NHAP VAO
CREATE OR REPLACE TRIGGER encrypt_data_LUONGCOBAN_PHUCAP
BEFORE INSERT OR UPDATE ON NHANVIEN
FOR EACH ROW
BEGIN 
    :NEW.LUONGCOBAN := ENCRYPT_DATA (:NEW.LUONGCOBAN, :NEW.MANHANVIEN);
    :NEW.PHUCAP := ENCRYPT_DATA (:NEW.PHUCAP, :NEW.MANHANVIEN);
END;
/

--MA HOA TRIEU CHUNG VA KET LUAN CUA BS KHI NHAP VAO
CREATE OR REPLACE TRIGGER encrypt_data_TRIEUCHUNG_KETLUAN
BEFORE INSERT OR UPDATE ON PHIEUKHAMBENH
FOR EACH ROW
BEGIN 
    :NEW.TRIEUCHUNG := ENCRYPT_DATA (:NEW.TRIEUCHUNG, :NEW.MAKHAMBENH);
    :NEW.KETLUANCUABACSI := ENCRYPT_DATA (:NEW.KETLUANCUABACSI, :NEW.MAKHAMBENH);
END;
/

--MA HOA KET QUA DICH VU TRONG PHIEU YEU CAU DICH VU
CREATE OR REPLACE TRIGGER encrypt_data_KETQUADICHVU
BEFORE INSERT OR UPDATE ON KETQUADICHVU
FOR EACH ROW
BEGIN 
    :NEW.KETQUADICHVU := ENCRYPT_DATA (:NEW.KETQUADICHVU, :NEW.MAKHAMBENH);
END;
/

-----DECRYPT-----------
---Using format "(decrypt_data(data, key))" to decrypt
---NHANVIEN => key: MANHANVIEN
---PHIEUKHAMBENH => key: MAKHAMBENH
---PHIEUYEUCAUDICHVU => key: MAKHAMBENH
