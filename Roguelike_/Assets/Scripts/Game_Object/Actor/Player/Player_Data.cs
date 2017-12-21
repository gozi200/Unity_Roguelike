using UnityEngine;
using System.Collections;
using System.Linq;

public class Player_Data : MonoBehaviour {
    private class Read_Player_Data {
        [CsvColumnAttribute(0, 0)]
        private int id;

        [CsvColumnAttribute(1, "NoName")]
        public string Name {
            get;
            set;
        }

        [CsvColumnAttribute(2, 100)]
        public int Hp;

        public override string ToString() {
            return string.Format("Id={0}, Name={1}, HP={2}", id, Name, Hp);
        }
    }

    void Start() {
        //readerをList<TestEnemyData>化して、それぞれ表示
        using (var reader = new CSVReader<Player_Data>("csv/Actor/Player/Player", true)) {
            reader.ToList().ForEach(player => Debug.Log(player.ToString()));
        }
    }

    // Update is called once per frame
    void Update() {

    }
}