<script setup lang="ts">
</script>

<template>
    <header>
        <div class="routeMain">
            <br />
            <p>
                <input type="text" id="iptStartLoc" name="iptStartLoc" placeholder="Starting Location: " />
                <input type="text" id="iptDest" name="iptDest" placeholder="Destination: " />
            </p>
            <p>
                <input type="checkbox" id="cbAvoidTolls" name="cbAvoidTolls" />
                <label for="cbAvoidTolls">Avoid Tolls </label>
                <br />
                <input type="checkbox" id="cbAvoidHighways" name="cbAvoidHighways" />
                <label for="cbAvoidHighways">Avoid Highways </label>
            </p>
            <p>
                <button type="button">Calculate Route</button>
            </p>
        </div>
        <div class="routeStop">
            <br />
            <p>
                <button type="button" @click="addStop">+</button>
                <input type="text" v-model="iptStop" name="iptStop" placeholder="Name of Stop: " />
            </p>
            <p>
                <ul id="stopList">
                    <h2 v-for="(stop, i) in stops" :key="i">
                        {{ stop }}
                    </h2>
                </ul>
            </p>
        </div>
    </header>
</template>

<style scoped>
    .routeMain {
        height: 400px;
        width: 400px;
        border-radius: 15%;
        background-color: #77c3ec;
        margin-top: 50px;
        margin-left: 50px;
    }

        .routeMain p {
            vertical-align: middle;
            display: block;
            margin-top: 45px;
            margin-left: 130px;
            transform: scale(1.45);
        }

        .routeMain input, button {
            margin-top: 10px;
        }

        .routeMain label {
            margin-left: 10px;
        }

    .routeStop {
        height: 400px;
        width: 400px;
        border-radius: 15%;
        background-color: #77c3ec;
        margin-top: 50px;
        margin-left: 50px;
    }

        .routeStop p {
            vertical-align: middle;
            display: block;
            margin-top: 30px;
            margin-left: 130px;
            transform: scale(1.45);
        }

        .routeStop ul, button {
            margin-top: 10px;
        }

        .routeStop label {
            margin-left: 10px;
        }

        .routeStop li {
            margin-top: 10px;
        }
</style>

<script>
    export default {
        data() {
            iptStop: ""
            return {
                stops: [],
            };
        },
        methods: {
            addStop() {
                this.stops.push(this.iptStop + '- ' + (Math.floor(Math.random() * 10) + 1) + 'm');
            },
        },
    };
</script>
