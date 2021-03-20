<template>
  <div>
    <b-container fluid>
      <b-card-group deck>
        <b-card
          bg-variant="secondary"
          text-variant="white"
          header="Axial"
          class="text-center">
          <b-card-body>
            <canvas id="canvasAreaOne"></canvas>
            <b-button class="m-3" variant="success" @click="incrementSlide('up')">+</b-button>
            <b-button class="m-3" variant="danger" @click="incrementSlide('down')">-</b-button>
          </b-card-body>
        </b-card>
        <b-card
          bg-variant="secondary"
          text-variant="white"
          header="Coronal"
          class="text-center">
          <b-card-body>
            <canvas id="canvasAreaTwo"></canvas>
          </b-card-body>
        </b-card>
      </b-card-group>
    </b-container>
    <b-button class="m-3" variant="success" @click="loadData">Load Data</b-button>
  </div>
</template>
<script>
export default {
  name: "Canvas",
  data() {
    return {
      canvasOneData: [
        {
          slide: [
            { x: 30, y: 30 },
            { x: 10, y: 50 },
            { x: 100, y: 80 },
            { x: 110, y: 50 },
            { x: 60, y: 30 },
            { x: 30, y: 30 },
          ],
        },
        {
          slide: [
            { x: 35, y: 35 },
            { x: 15, y: 55 },
            { x: 105, y: 85 },
            { x: 115, y: 55 },
            { x: 65, y: 35 },
            { x: 35, y: 35 },
          ],
        },
        {
          slide: [
            { x: 45, y: 35 },
            { x: 25, y: 55 },
            { x: 135, y: 85 },
            { x: 145, y: 55 },
            { x: 75, y: 35 },
            { x: 45, y: 35 },
          ],
        },
      ],
      vueCanvas: null,
      canvas: {},
      canvasOneSideNumber: 0
    };
  },
  mounted() {
    this.canvas = document.getElementById("canvasAreaOne");
  },
  methods: {
    loadData() {
      var canvasdraw = this.canvas.getContext("2d");
      canvasdraw.clearRect(0, 0, this.canvas.width, this.canvas.height);
      canvasdraw.beginPath();
      canvasdraw.strokeStyle = "black";
      canvasdraw.lineWidth = 2;
      var slide = this.canvasOneData[this.canvasOneSideNumber].slide;
      console.log(slide);
      slide.forEach(function (element, index) {
        if (index === 0) {
          canvasdraw.moveTo(element.x, element.y);
        } else {
          canvasdraw.lineTo(element.x, element.y);
        }
      });
      canvasdraw.stroke();
      canvasdraw.closePath();
    },
    incrementSlide(direction){
        if(direction == "up"){
            this.canvasOneSideNumber ++;
        }
        if(direction == "down"){
            this.canvasOneSideNumber --;
        }
        this.loadData();
    }
  },
};
</script>
<style scoped>
#canvasAreaOne {
  border: black solid 5px;
  background-color: azure;
  width: 500px;
  height: 350px;
}
#canvasAreaTwo {
  border: black solid 5px;
  background-color: azure;
  width: 500px;
  height: 350px;
}
</style>