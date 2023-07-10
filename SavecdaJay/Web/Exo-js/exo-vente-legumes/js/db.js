class Db
{
    static async fechData(_url)
    {
        let response = await fetch(_url);
        let json = await response.json();
        return json;
    }
}
export{Db};